﻿
// Copyright (C) 2016 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

using System;
using System.Collections.Generic;

using OpenGL.Objects.State;

namespace OpenGL.Objects.Scene
{
	/// <summary>
	/// Scene graph object sorter.
	/// </summary>
	abstract class SceneGraphSorter
	{
		/// <summary>
		/// Sort a sequence of <see cref="SceneObjectBatch"/>.
		/// </summary>
		/// <param name="objects">
		/// A <see cref="List{SceneObjectBatch}"/> indicating the sequence of scene objects to be sorted.
		/// </param>
		/// <returns>
		/// It returns a <see cref="List{SceneObjectBatch}"/> containing all objects found in <paramref name="objects"/>, but
		/// ordered following the concrete implementation criteria.
		/// </returns>
		public virtual List<SceneObjectBatch> Sort(List<SceneObjectBatch> objects)
		{
			List<SceneObjectBatch> sorted = new List<SceneObjectBatch>(objects.Count);
			KeyValuePair<SceneGraphSorter, List<SceneObjectBatch>>[] chunks = Split(objects);

			// Sort recursively
			foreach (KeyValuePair<SceneGraphSorter, List<SceneObjectBatch>> pair in chunks) {
				if (pair.Key != null)
					sorted.AddRange(pair.Key.Sort(pair.Value));
				else
					sorted.AddRange(pair.Value);
			}

			return (sorted);
		}

		/// <summary>
		/// Split the input sequence into smaller sequences, associated to a <see cref="SceneGraphSorter"/> used for sorting recursively
		/// the individual sequences.
		/// </summary>
		/// <param name="objects">
		/// A <see cref="List{SceneObjectBatch}"/> indicating the sequence of scene objects to be splitted in sub-sequences.
		/// </param>
		/// <returns>
		/// It returns a <see cref="T:KeyValuePair{SceneGraphSorter, List{SceneObjectBatch}}[]"/> indicating a set of <see cref="List{SceneObjectBatch}"/>
		/// associated to a <see cref="SceneGraphSorter"/>.
		/// </returns>
		protected abstract KeyValuePair<SceneGraphSorter, List<SceneObjectBatch>>[] Split(List<SceneObjectBatch> objects);
	}

	/// <summary>
	/// Scene graph object sorter, binary filtering (useful for simplae states).
	/// </summary>
	abstract class SceneObjectSorterBinary : SceneGraphSorter
	{
		#region Sorter Chaining

		public SceneGraphSorter SorterA
		{
			get; set;
		}

		public SceneGraphSorter SorterB
		{
			get; set;
		}

		protected abstract bool ComparePriority(SceneObjectBatch objectBatch);

		#endregion

		#region ObjectSorter Overrides

		/// <summary>
		/// Split the input sequence into smaller sequences, associated to a <see cref="SceneGraphSorter"/> used for sorting recursively
		/// the individual sequences.
		/// </summary>
		/// <param name="objects"></param>
		/// <returns></returns>
		protected override KeyValuePair<SceneGraphSorter, List<SceneObjectBatch>>[] Split(List<SceneObjectBatch> objects)
		{
			if (objects == null)
				throw new ArgumentNullException("objects");

			List<SceneObjectBatch> a = new List<SceneObjectBatch>();
			List<SceneObjectBatch> b = new List<SceneObjectBatch>();

			foreach (SceneObjectBatch objectBatch in objects) {
				if (ComparePriority(objectBatch))
					a.Add(objectBatch);
				else
					b.Add(objectBatch);
			}

			return (new KeyValuePair<SceneGraphSorter, List<SceneObjectBatch>>[] {
				new KeyValuePair<SceneGraphSorter, List<SceneObjectBatch>>(SorterA, a),
				new KeyValuePair<SceneGraphSorter, List<SceneObjectBatch>>(SorterB, b)
			});
		}

		#endregion
	}

	abstract class SceneObjectSorterCompare : SceneGraphSorter, IComparer<SceneObjectBatch>
	{
		#region IComparer<ObjectBatch> Implementation

		public abstract int Compare(SceneObjectBatch x, SceneObjectBatch y);

		#endregion

		#region ObjectSorterBase Overrides

		/// <summary>
		/// 
		/// </summary>
		/// <param name="objects"></param>
		/// <returns></returns>
		public override List<SceneObjectBatch> Sort(List<SceneObjectBatch> objects)
		{
			if (objects == null)
				throw new ArgumentNullException("objects");

			objects.Sort(this);

			return (objects);
		}

		#endregion
	}

	class SceneObjectSorterBlend : SceneObjectSorterBinary
	{
		#region ObjectSorterBinary Overrides

		protected override bool ComparePriority(SceneObjectBatch objectBatch)
		{
			BlendState blendState = (BlendState)objectBatch.State[BlendState.StateSetIndex];

			return (blendState == null || !blendState.Enabled);
		}

		#endregion
	}

	class SceneObjectSorterProgram : SceneGraphSorter
	{
		#region Sorter Chaining

		public SceneGraphSorter Sorter
		{
			get; set;
		}

		#endregion

		#region SceneGraphSorter Overrides

		/// <summary>
		/// Split the input sequence into smaller sequences, associated to a <see cref="SceneGraphSorter"/> used for sorting recursively
		/// the individual sequences.
		/// </summary>
		/// <param name="objects"></param>
		/// <returns></returns>
		protected override KeyValuePair<SceneGraphSorter, List<SceneObjectBatch>>[] Split(List<SceneObjectBatch> objects)
		{
			Dictionary<ShaderProgram, List<SceneObjectBatch>> programLists = new Dictionary<ShaderProgram, List<SceneObjectBatch>>();

			foreach (SceneObjectBatch objectBatch in objects) {
				List<SceneObjectBatch> programList;

				if (programLists.TryGetValue(objectBatch.Program, out programList)) {
					programList.Add(objectBatch);
					continue;
				}

				programList = new List<SceneObjectBatch>();
				programList.Add(objectBatch);
				programLists.Add(objectBatch.Program, programList);
			}

			List<KeyValuePair<SceneGraphSorter, List<SceneObjectBatch>>> subseqs = new List<KeyValuePair<SceneGraphSorter, List<SceneObjectBatch>>>();
			foreach (KeyValuePair<ShaderProgram, List<SceneObjectBatch>> pair in programLists)
				subseqs.Add(new KeyValuePair<SceneGraphSorter, List<SceneObjectBatch>>(Sorter, pair.Value));
			return (subseqs.ToArray());
		}

		#endregion
	}
}
