﻿
// Copyright (C) 2009-2016 Luca Piccioni
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
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace OpenGL
{
	/// <summary>
	/// Vertex value type (byte coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.UByte, 3)]
	[DebuggerDisplay("Vertex3ub: X={x} Y={y} Z={z}")]
	public struct Vertex3ub : IVertex3, IEquatable<IVertex3>
	{
		#region Constructors

		/// <summary>
		/// Vertex3ub constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="byte"/> that specify the value of every component.
		/// </param>
		public Vertex3ub(byte v) : this(v, v, v) { }

		/// <summary>
		/// Vertex3ub constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="byte[]"/> that specify the value of every component.
		/// </param>
		public Vertex3ub(byte[] v) : this(v[0], v[1], v[2]) { }

		/// <summary>
		/// Vertex3ub constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="byte"/> that specify the X coordinate.
		/// </param>
		/// <param name="y">
		/// A <see cref="byte"/> that specify the Y coordinate.
		/// </param>
		/// <param name="z">
		/// A <see cref="byte"/> that specify the Z coordinate.
		/// </param>
		public Vertex3ub(byte x, byte y, byte z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		/// <summary>
		/// Vertex3ub constructor.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Vertex3ub"/> that specify the vertex to be copied.
		/// </param>
		public Vertex3ub(Vertex3ub other) : this(other.x, other.y, other.z) { }

		#endregion

		#region Structure

		/// <summary>
		/// X coordinate for tridimensional vertex.
		/// </summary>
		public byte x;

		/// <summary>
		/// Y coordinate for tridimensional vertex.
		/// </summary>
		public byte y;

		/// <summary>
		/// Z coordinate for tridimensional vertex.
		/// </summary>
		public byte z;

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3ub"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3ub"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3ub"/> that equals to the addition of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex3ub operator +(Vertex3ub v1, Vertex3ub v2)
		{
			Vertex3ub v;

			v.x = (byte)(v1.x + v2.x);
			v.y = (byte)(v1.y + v2.y);
			v.z = (byte)(v1.z + v2.z);

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3ub"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3ub"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3ub"/> that equals to the subtraction of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex3ub operator -(Vertex3ub v1, Vertex3ub v2)
		{
			Vertex3ub v;

			v.x = (byte)(v1.x - v2.x);
			v.y = (byte)(v1.y - v2.y);
			v.z = (byte)(v1.z - v2.z);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3ub"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3ub"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3ub operator *(Vertex3ub v1, float scalar)
		{
			Vertex3ub v;

			v.x = (byte)(v1.x * scalar);
			v.y = (byte)(v1.y * scalar);
			v.z = (byte)(v1.z * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3ub"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3ub"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3ub operator *(Vertex3ub v1, double scalar)
		{
			Vertex3ub v;

			v.x = (byte)(v1.x * scalar);
			v.y = (byte)(v1.y * scalar);
			v.z = (byte)(v1.z * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3ub"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3ub"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3ub operator /(Vertex3ub v1, float scalar)
		{
			Vertex3ub v;

			v.x = (byte)(v1.x / scalar);
			v.y = (byte)(v1.y / scalar);
			v.z = (byte)(v1.z / scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3ub"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3ub"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3ub operator /(Vertex3ub v1, double scalar)
		{
			Vertex3ub v;

			v.x = (byte)(v1.x / scalar);
			v.y = (byte)(v1.y / scalar);
			v.z = (byte)(v1.z / scalar);

			return (v);
		}

		/// <summary>
		/// Dot product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3ub"/> representing the left dot product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3ub"/> representing the right dot product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3ub"/> representing the dot product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static float operator *(Vertex3ub v1, Vertex3ub v2)
		{
			return (float)(v1.x * v2.x + v1.y * v2.y + v1.z * v2.z);
		}

		/// <summary>
		/// Cross product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3ub"/> representing the left cross product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3ub"/> representing the right cross product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3ub"/> representing the cross product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static Vertex3f operator ^(Vertex3ub v1, Vertex3ub v2)
		{
			Vertex3f v;

			v.x = (float)(v1.y * v2.z - v1.z * v2.y);
			v.y = (float)(v1.z * v2.x - v1.x * v2.z);
			v.z = (float)(v1.x * v2.y - v1.y * v2.x);

			return (v);
		}

		/// <summary>
		/// Vertex and matrix multiplication.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex3ub"/> representing the vertex to be transformed.
		/// </param>
		/// <param name="m">
		/// A <see cref="Matrix4x4"/> representing the transformation matrix.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Vertex3f"/> which represents the transformed vertex.
		/// </returns>
		public static Vertex3f operator *(Vertex3ub v, Matrix4x4 m)
		{
			Vertex3f r;

			r.x = (float)((v.x * m[0, 0]) + (v.y * m[0, 1]) + (v.z * m[0, 2]) + m[0, 3]);
			r.y = (float)((v.x * m[1, 1]) + (v.y * m[1, 1]) + (v.z * m[1, 2]) + m[1, 3]);
			r.z = (float)((v.x * m[2, 2]) + (v.y * m[2, 1]) + (v.z * m[2, 2]) + m[2, 3]);

			return (r);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3ub"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="byte"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3ub"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3ub operator *(Vertex3ub v1, byte scalar)
		{
			Vertex3ub v;

			v.x = (byte)(v1.x * scalar);
			v.y = (byte)(v1.y * scalar);
			v.z = (byte)(v1.z * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3ub"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="byte"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3ub"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3ub operator /(Vertex3ub v1, byte scalar)
		{
			Vertex3ub v;

			v.x = (byte)(v1.x / scalar);
			v.y = (byte)(v1.y / scalar);
			v.z = (byte)(v1.z / scalar);

			return (v);
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(Vertex3ub v1, Vertex3ub v2)
		{
			return (v1.Equals(v2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(Vertex3ub v1, Vertex3ub v2)
		{
			return (!v1.Equals(v2));
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to byte[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3ub"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="byte[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator byte[](Vertex3ub a)
		{
			byte[] v = new byte[3];

			v[0] = a.x;
			v[1] = a.y;
			v[2] = a.z;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex2f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3ub"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> initialized with the vector components, ignoring the Z component.
		/// </returns>
		public static explicit operator Vertex2f(Vertex3ub v)
		{
			return (new Vertex2f(v.X, v.Y));
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3ub"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex3f(Vertex3ub v)
		{
			return (new Vertex3f(v.X, v.Y, v.Z));
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3ub"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex3d(Vertex3ub v)
		{
			return (new Vertex3d(v.X, v.Y, v.Z));
		}

		/// <summary>
		/// Cast to Vertex4f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3ub"/> to be casted.
		/// </param>
		/// <returns>
		/// A normalized <see cref="Vertex4f"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4f(Vertex3ub v)
		{
			return (new Vertex4f(v.X, v.Y, v.Z, 1.0f));
		}

		/// <summary>
		/// Cast to Vertex4d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3ub"/> to be casted.
		/// </param>
		/// <returns>
		/// A normalized <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4d(Vertex3ub v)
		{
			return (new Vertex4d(v.X, v.Y, v.Z, 1.0f));
		}

		#endregion

		#region Vertex Methods

		/// <summary>
		/// Compute tridimensional vertex module.
		/// </summary>
		/// <returns>
		/// It returns the vertex vector module.
		/// </returns>
		public float Module()
		{
			float x2 = (float)(x * x);
			float y2 = (float)(y * y);
			float z2 = (float)(z * z);

			return ((float)Math.Sqrt(x2 + y2 + z2));
		}

		/// <summary>
		/// Normalize vertex coordinates.
		/// </summary>
		public void Normalize()
		{
			float length = Module();

			if (Math.Abs(length) < Single.Epsilon)
				throw new DivideByZeroException("zero length normalization");

			this /= length;
		}

		/// <summary>
		/// This vertex, but normalized.
		/// </summary>
		public Vertex3ub Normalized
		{
			get
			{
				Vertex3ub normalized = this;

				normalized.Normalize();

				return (normalized);
			}
		}

		#endregion

		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex3ub Zero = new Vertex3ub(0);

		/// <summary>
		/// Unit vertex along all axes.
		/// </summary>
		public static readonly Vertex3ub One = new Vertex3ub(1);

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly Vertex3ub UnitX = new Vertex3ub(1, 0, 0);

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly Vertex3ub UnitY = new Vertex3ub(0, 1, 0);

		/// <summary>
		/// Unit vertex along Z axis.
		/// </summary>
		public static readonly Vertex3ub UnitZ = new Vertex3ub(0, 0, 1);

		#endregion

		#region IVertex3 Implementation

		/// <summary>
		/// Vertex coordinate X, normalized in range [0.0, 1.0].
		/// </summary>
		public float X
		{
			get { return ((float)x / (float)byte.MaxValue); }
			set
			{
				if (value < 0.0f || value > 1.0)
					throw new InvalidOperationException("value out of range");
				x = (byte)(value * (float)byte.MaxValue);
			}
		}

		/// <summary>
		/// Vertex coordinate Y, normalized in range [0.0, 1.0].
		/// </summary>
		public float Y
		{
			get { return ((float)y / (float)byte.MaxValue); }
			set
			{
				if (value < 0.0f || value > 1.0)
					throw new InvalidOperationException("value out of range");
				y = (byte)(value * (float)byte.MaxValue);
			}
		}

		/// <summary>
		/// Vertex coordinate Z, normalized in range [0.0, 1.0].
		/// </summary>
		public float Z
		{
			get { return ((float)z / (float)byte.MaxValue); }
			set
			{
				if (value < 0.0f || value > 1.0)
					throw new InvalidOperationException("value out of range");
				z = (byte)(value * (float)byte.MaxValue);
			}
		}

		#endregion

		#region IVertex Implementation

		/// <summary>
		/// Vertex components indexer.
		/// </summary>
		/// <param name="idx">
		/// A <see cref="UInt32"/> that specify the component index using for accessing to this IVertex component.
		/// </param>
		/// <remarks>
		/// <para>
		/// This indexer returns a single-precision floating-point representation of the vertex component value.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception thrown if <paramref name="idx"/> exceeds the maximum allowed component index.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the set value is outside the representable range of the underlying type.
		/// </exception>s
		public float this[uint idx]
		{
			get
			{
				switch (idx) {
					case 0: return (X);
					case 1: return (Y);
					case 2: return (Z);
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0: X = value; break;
					case 1: Y = value; break;
					case 2: Z = value; break;
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
		}

		#endregion

		#region IEquatable<IVertex3> Implementation

		/// <summary>
		/// Indicates whether the this IVertex3 is equal to another IVertex3.
		/// </summary>
		/// <param name="other">
		/// An IVertex3 to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IVertex3 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(IVertex3 other)
		{
			const float Epsilon = 1e-6f;

			if (ReferenceEquals(null, other))
				return false;

			if (Math.Abs(X - other.X) >= Epsilon)
				return (false);
			if (Math.Abs(Y - other.Y) >= Epsilon)
				return (false);
			if (Math.Abs(Z - other.Z) >= Epsilon)
				return (false);

			return (true);
		}

		/// <summary>
		/// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
		/// </summary>
		/// <param name="obj">
		/// The <see cref="T:System.Object"/> to compare with the current <see cref="T:System.Object"/>.
		/// </param>
		/// <returns>
		/// It returns true if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.
		/// </returns>
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj))
				return (false);
			if (obj.GetType().GetInterface("IVertex3") == null)
				return (false);

			return (Equals((IVertex3)obj));
		}

		/// <summary>
		/// Serves as a hash function for a particular type. <see cref="M:System.Object.GetHashCode"/> is suitable for
		/// use in hashing algorithms and data structures like a hash table.
		/// </summary>
		/// <returns>
		/// A hash code for the current <see cref="T:System.Object"/>.
		/// </returns>
		public override int GetHashCode()
		{
			unchecked {
				int result = x.GetHashCode();
				result = (result * 397) ^ y.GetHashCode();
				result = (result * 397) ^ z.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex3ub.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex3ub.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0}, {1}, {2}|", x, y, z));
		}

		#endregion
	}

	/// <summary>
	/// Vertex value type (sbyte coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Byte, 3)]
	[DebuggerDisplay("Vertex3b: X={x} Y={y} Z={z}")]
	public struct Vertex3b : IVertex3, IEquatable<IVertex3>
	{
		#region Constructors

		/// <summary>
		/// Vertex3b constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="sbyte"/> that specify the value of every component.
		/// </param>
		public Vertex3b(sbyte v) : this(v, v, v) { }

		/// <summary>
		/// Vertex3b constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="sbyte[]"/> that specify the value of every component.
		/// </param>
		public Vertex3b(sbyte[] v) : this(v[0], v[1], v[2]) { }

		/// <summary>
		/// Vertex3b constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="sbyte"/> that specify the X coordinate.
		/// </param>
		/// <param name="y">
		/// A <see cref="sbyte"/> that specify the Y coordinate.
		/// </param>
		/// <param name="z">
		/// A <see cref="sbyte"/> that specify the Z coordinate.
		/// </param>
		public Vertex3b(sbyte x, sbyte y, sbyte z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		/// <summary>
		/// Vertex3b constructor.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Vertex3b"/> that specify the vertex to be copied.
		/// </param>
		public Vertex3b(Vertex3b other) : this(other.x, other.y, other.z) { }

		#endregion

		#region Structure

		/// <summary>
		/// X coordinate for tridimensional vertex.
		/// </summary>
		public sbyte x;

		/// <summary>
		/// Y coordinate for tridimensional vertex.
		/// </summary>
		public sbyte y;

		/// <summary>
		/// Z coordinate for tridimensional vertex.
		/// </summary>
		public sbyte z;

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Negate operator.
		/// </summary>
		/// <param name="v">
		/// The Vertex3b to negate.
		/// </param>
		/// <returns>
		/// It returns the negate of <paramref name="v"/>.
		/// </returns>
		public static Vertex3b operator -(Vertex3b v)
		{
			return (new Vertex3b((sbyte)(-v.x), (sbyte)(-v.y), (sbyte)(-v.z)));
		}

		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3b"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3b"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3b"/> that equals to the addition of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex3b operator +(Vertex3b v1, Vertex3b v2)
		{
			Vertex3b v;

			v.x = (sbyte)(v1.x + v2.x);
			v.y = (sbyte)(v1.y + v2.y);
			v.z = (sbyte)(v1.z + v2.z);

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3b"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3b"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3b"/> that equals to the subtraction of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex3b operator -(Vertex3b v1, Vertex3b v2)
		{
			Vertex3b v;

			v.x = (sbyte)(v1.x - v2.x);
			v.y = (sbyte)(v1.y - v2.y);
			v.z = (sbyte)(v1.z - v2.z);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3b"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3b"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3b operator *(Vertex3b v1, float scalar)
		{
			Vertex3b v;

			v.x = (sbyte)(v1.x * scalar);
			v.y = (sbyte)(v1.y * scalar);
			v.z = (sbyte)(v1.z * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3b"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3b"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3b operator *(Vertex3b v1, double scalar)
		{
			Vertex3b v;

			v.x = (sbyte)(v1.x * scalar);
			v.y = (sbyte)(v1.y * scalar);
			v.z = (sbyte)(v1.z * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3b"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3b"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3b operator /(Vertex3b v1, float scalar)
		{
			Vertex3b v;

			v.x = (sbyte)(v1.x / scalar);
			v.y = (sbyte)(v1.y / scalar);
			v.z = (sbyte)(v1.z / scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3b"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3b"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3b operator /(Vertex3b v1, double scalar)
		{
			Vertex3b v;

			v.x = (sbyte)(v1.x / scalar);
			v.y = (sbyte)(v1.y / scalar);
			v.z = (sbyte)(v1.z / scalar);

			return (v);
		}

		/// <summary>
		/// Dot product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3b"/> representing the left dot product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3b"/> representing the right dot product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3b"/> representing the dot product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static float operator *(Vertex3b v1, Vertex3b v2)
		{
			return (float)(v1.x * v2.x + v1.y * v2.y + v1.z * v2.z);
		}

		/// <summary>
		/// Cross product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3b"/> representing the left cross product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3b"/> representing the right cross product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3b"/> representing the cross product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static Vertex3f operator ^(Vertex3b v1, Vertex3b v2)
		{
			Vertex3f v;

			v.x = (float)(v1.y * v2.z - v1.z * v2.y);
			v.y = (float)(v1.z * v2.x - v1.x * v2.z);
			v.z = (float)(v1.x * v2.y - v1.y * v2.x);

			return (v);
		}

		/// <summary>
		/// Vertex and matrix multiplication.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex3b"/> representing the vertex to be transformed.
		/// </param>
		/// <param name="m">
		/// A <see cref="Matrix4x4"/> representing the transformation matrix.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Vertex3f"/> which represents the transformed vertex.
		/// </returns>
		public static Vertex3f operator *(Vertex3b v, Matrix4x4 m)
		{
			Vertex3f r;

			r.x = (float)((v.x * m[0, 0]) + (v.y * m[0, 1]) + (v.z * m[0, 2]) + m[0, 3]);
			r.y = (float)((v.x * m[1, 1]) + (v.y * m[1, 1]) + (v.z * m[1, 2]) + m[1, 3]);
			r.z = (float)((v.x * m[2, 2]) + (v.y * m[2, 1]) + (v.z * m[2, 2]) + m[2, 3]);

			return (r);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3b"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="sbyte"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3b"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3b operator *(Vertex3b v1, sbyte scalar)
		{
			Vertex3b v;

			v.x = (sbyte)(v1.x * scalar);
			v.y = (sbyte)(v1.y * scalar);
			v.z = (sbyte)(v1.z * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3b"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="sbyte"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3b"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3b operator /(Vertex3b v1, sbyte scalar)
		{
			Vertex3b v;

			v.x = (sbyte)(v1.x / scalar);
			v.y = (sbyte)(v1.y / scalar);
			v.z = (sbyte)(v1.z / scalar);

			return (v);
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(Vertex3b v1, Vertex3b v2)
		{
			return (v1.Equals(v2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(Vertex3b v1, Vertex3b v2)
		{
			return (!v1.Equals(v2));
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to sbyte[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3b"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="sbyte[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator sbyte[](Vertex3b a)
		{
			sbyte[] v = new sbyte[3];

			v[0] = a.x;
			v[1] = a.y;
			v[2] = a.z;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex2f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3b"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> initialized with the vector components, ignoring the Z component.
		/// </returns>
		public static explicit operator Vertex2f(Vertex3b v)
		{
			return (new Vertex2f(v.X, v.Y));
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3b"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex3f(Vertex3b v)
		{
			return (new Vertex3f(v.X, v.Y, v.Z));
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3b"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex3d(Vertex3b v)
		{
			return (new Vertex3d(v.X, v.Y, v.Z));
		}

		/// <summary>
		/// Cast to Vertex4f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3b"/> to be casted.
		/// </param>
		/// <returns>
		/// A normalized <see cref="Vertex4f"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4f(Vertex3b v)
		{
			return (new Vertex4f(v.X, v.Y, v.Z, 1.0f));
		}

		/// <summary>
		/// Cast to Vertex4d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3b"/> to be casted.
		/// </param>
		/// <returns>
		/// A normalized <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4d(Vertex3b v)
		{
			return (new Vertex4d(v.X, v.Y, v.Z, 1.0f));
		}

		#endregion

		#region Vertex Methods

		/// <summary>
		/// Compute tridimensional vertex module.
		/// </summary>
		/// <returns>
		/// It returns the vertex vector module.
		/// </returns>
		public float Module()
		{
			float x2 = (float)(x * x);
			float y2 = (float)(y * y);
			float z2 = (float)(z * z);

			return ((float)Math.Sqrt(x2 + y2 + z2));
		}

		/// <summary>
		/// Normalize vertex coordinates.
		/// </summary>
		public void Normalize()
		{
			float length = Module();

			if (Math.Abs(length) < Single.Epsilon)
				throw new DivideByZeroException("zero length normalization");

			this /= length;
		}

		/// <summary>
		/// This vertex, but normalized.
		/// </summary>
		public Vertex3b Normalized
		{
			get
			{
				Vertex3b normalized = this;

				normalized.Normalize();

				return (normalized);
			}
		}

		#endregion

		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex3b Zero = new Vertex3b(0);

		/// <summary>
		/// Unit vertex along all axes.
		/// </summary>
		public static readonly Vertex3b One = new Vertex3b(1);

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly Vertex3b UnitX = new Vertex3b(1, 0, 0);

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly Vertex3b UnitY = new Vertex3b(0, 1, 0);

		/// <summary>
		/// Unit vertex along Z axis.
		/// </summary>
		public static readonly Vertex3b UnitZ = new Vertex3b(0, 0, 1);

		#endregion

		#region IVertex3 Implementation

		/// <summary>
		/// Vertex coordinate X, normalized in range [-1.0, +1.0].
		/// </summary>
		public float X
		{
			get { return ((float)(x - sbyte.MinValue) / ((long)sbyte.MaxValue - (long)sbyte.MinValue)) * 2.0f - 1.0f; }
			set
			{
				if (value < -1.0f || value > +1.0)
					throw new InvalidOperationException("value out of range");
				x = (sbyte)((value * 0.5f + 0.5f) * ((long)sbyte.MaxValue - (long)sbyte.MinValue) + sbyte.MinValue);
			}
		}

		/// <summary>
		/// Vertex coordinate Y, normalized in range [-1.0, +1.0]..
		/// </summary>
		public float Y
		{
			get { return ((float)(y - sbyte.MinValue) / ((long)sbyte.MaxValue - (long)sbyte.MinValue)) * 2.0f - 1.0f; }
			set
			{
				if (value < -1.0f || value > +1.0)
					throw new InvalidOperationException("value out of range");
				y = (sbyte)((value * 0.5f + 0.5f) * ((long)sbyte.MaxValue - (long)sbyte.MinValue) + sbyte.MinValue);
			}
		}

		/// <summary>
		/// Vertex coordinate Z, normalized in range [-1.0, +1.0]..
		/// </summary>
		public float Z
		{
			get { return ((float)(z - sbyte.MinValue) / ((long)sbyte.MaxValue - (long)sbyte.MinValue)) * 2.0f - 1.0f; }
			set
			{
				if (value < -1.0f || value > +1.0)
					throw new InvalidOperationException("value out of range");
				z = (sbyte)((value * 0.5f + 0.5f) * ((long)sbyte.MaxValue - (long)sbyte.MinValue) + sbyte.MinValue);
			}
		}

		#endregion

		#region IVertex Implementation

		/// <summary>
		/// Vertex components indexer.
		/// </summary>
		/// <param name="idx">
		/// A <see cref="UInt32"/> that specify the component index using for accessing to this IVertex component.
		/// </param>
		/// <remarks>
		/// <para>
		/// This indexer returns a single-precision floating-point representation of the vertex component value.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception thrown if <paramref name="idx"/> exceeds the maximum allowed component index.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the set value is outside the representable range of the underlying type.
		/// </exception>s
		public float this[uint idx]
		{
			get
			{
				switch (idx) {
					case 0: return (X);
					case 1: return (Y);
					case 2: return (Z);
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0: X = value; break;
					case 1: Y = value; break;
					case 2: Z = value; break;
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
		}

		#endregion

		#region IEquatable<IVertex3> Implementation

		/// <summary>
		/// Indicates whether the this IVertex3 is equal to another IVertex3.
		/// </summary>
		/// <param name="other">
		/// An IVertex3 to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IVertex3 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(IVertex3 other)
		{
			const float Epsilon = 1e-6f;

			if (ReferenceEquals(null, other))
				return false;

			if (Math.Abs(X - other.X) >= Epsilon)
				return (false);
			if (Math.Abs(Y - other.Y) >= Epsilon)
				return (false);
			if (Math.Abs(Z - other.Z) >= Epsilon)
				return (false);

			return (true);
		}

		/// <summary>
		/// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
		/// </summary>
		/// <param name="obj">
		/// The <see cref="T:System.Object"/> to compare with the current <see cref="T:System.Object"/>.
		/// </param>
		/// <returns>
		/// It returns true if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.
		/// </returns>
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj))
				return (false);
			if (obj.GetType().GetInterface("IVertex3") == null)
				return (false);

			return (Equals((IVertex3)obj));
		}

		/// <summary>
		/// Serves as a hash function for a particular type. <see cref="M:System.Object.GetHashCode"/> is suitable for
		/// use in hashing algorithms and data structures like a hash table.
		/// </summary>
		/// <returns>
		/// A hash code for the current <see cref="T:System.Object"/>.
		/// </returns>
		public override int GetHashCode()
		{
			unchecked {
				int result = x.GetHashCode();
				result = (result * 397) ^ y.GetHashCode();
				result = (result * 397) ^ z.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex3b.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex3b.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0}, {1}, {2}|", x, y, z));
		}

		#endregion
	}

	/// <summary>
	/// Vertex value type (ushort coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.UShort, 3)]
	[DebuggerDisplay("Vertex3us: X={x} Y={y} Z={z}")]
	public struct Vertex3us : IVertex3, IEquatable<IVertex3>
	{
		#region Constructors

		/// <summary>
		/// Vertex3us constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="ushort"/> that specify the value of every component.
		/// </param>
		public Vertex3us(ushort v) : this(v, v, v) { }

		/// <summary>
		/// Vertex3us constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="ushort[]"/> that specify the value of every component.
		/// </param>
		public Vertex3us(ushort[] v) : this(v[0], v[1], v[2]) { }

		/// <summary>
		/// Vertex3us constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="ushort"/> that specify the X coordinate.
		/// </param>
		/// <param name="y">
		/// A <see cref="ushort"/> that specify the Y coordinate.
		/// </param>
		/// <param name="z">
		/// A <see cref="ushort"/> that specify the Z coordinate.
		/// </param>
		public Vertex3us(ushort x, ushort y, ushort z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		/// <summary>
		/// Vertex3us constructor.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Vertex3us"/> that specify the vertex to be copied.
		/// </param>
		public Vertex3us(Vertex3us other) : this(other.x, other.y, other.z) { }

		#endregion

		#region Structure

		/// <summary>
		/// X coordinate for tridimensional vertex.
		/// </summary>
		public ushort x;

		/// <summary>
		/// Y coordinate for tridimensional vertex.
		/// </summary>
		public ushort y;

		/// <summary>
		/// Z coordinate for tridimensional vertex.
		/// </summary>
		public ushort z;

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3us"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3us"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3us"/> that equals to the addition of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex3us operator +(Vertex3us v1, Vertex3us v2)
		{
			Vertex3us v;

			v.x = (ushort)(v1.x + v2.x);
			v.y = (ushort)(v1.y + v2.y);
			v.z = (ushort)(v1.z + v2.z);

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3us"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3us"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3us"/> that equals to the subtraction of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex3us operator -(Vertex3us v1, Vertex3us v2)
		{
			Vertex3us v;

			v.x = (ushort)(v1.x - v2.x);
			v.y = (ushort)(v1.y - v2.y);
			v.z = (ushort)(v1.z - v2.z);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3us"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3us"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3us operator *(Vertex3us v1, float scalar)
		{
			Vertex3us v;

			v.x = (ushort)(v1.x * scalar);
			v.y = (ushort)(v1.y * scalar);
			v.z = (ushort)(v1.z * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3us"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3us"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3us operator *(Vertex3us v1, double scalar)
		{
			Vertex3us v;

			v.x = (ushort)(v1.x * scalar);
			v.y = (ushort)(v1.y * scalar);
			v.z = (ushort)(v1.z * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3us"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3us"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3us operator /(Vertex3us v1, float scalar)
		{
			Vertex3us v;

			v.x = (ushort)(v1.x / scalar);
			v.y = (ushort)(v1.y / scalar);
			v.z = (ushort)(v1.z / scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3us"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3us"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3us operator /(Vertex3us v1, double scalar)
		{
			Vertex3us v;

			v.x = (ushort)(v1.x / scalar);
			v.y = (ushort)(v1.y / scalar);
			v.z = (ushort)(v1.z / scalar);

			return (v);
		}

		/// <summary>
		/// Dot product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3us"/> representing the left dot product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3us"/> representing the right dot product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3us"/> representing the dot product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static float operator *(Vertex3us v1, Vertex3us v2)
		{
			return (float)(v1.x * v2.x + v1.y * v2.y + v1.z * v2.z);
		}

		/// <summary>
		/// Cross product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3us"/> representing the left cross product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3us"/> representing the right cross product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3us"/> representing the cross product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static Vertex3f operator ^(Vertex3us v1, Vertex3us v2)
		{
			Vertex3f v;

			v.x = (float)(v1.y * v2.z - v1.z * v2.y);
			v.y = (float)(v1.z * v2.x - v1.x * v2.z);
			v.z = (float)(v1.x * v2.y - v1.y * v2.x);

			return (v);
		}

		/// <summary>
		/// Vertex and matrix multiplication.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex3us"/> representing the vertex to be transformed.
		/// </param>
		/// <param name="m">
		/// A <see cref="Matrix4x4"/> representing the transformation matrix.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Vertex3f"/> which represents the transformed vertex.
		/// </returns>
		public static Vertex3f operator *(Vertex3us v, Matrix4x4 m)
		{
			Vertex3f r;

			r.x = (float)((v.x * m[0, 0]) + (v.y * m[0, 1]) + (v.z * m[0, 2]) + m[0, 3]);
			r.y = (float)((v.x * m[1, 1]) + (v.y * m[1, 1]) + (v.z * m[1, 2]) + m[1, 3]);
			r.z = (float)((v.x * m[2, 2]) + (v.y * m[2, 1]) + (v.z * m[2, 2]) + m[2, 3]);

			return (r);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3us"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="ushort"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3us"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3us operator *(Vertex3us v1, ushort scalar)
		{
			Vertex3us v;

			v.x = (ushort)(v1.x * scalar);
			v.y = (ushort)(v1.y * scalar);
			v.z = (ushort)(v1.z * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3us"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="ushort"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3us"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3us operator /(Vertex3us v1, ushort scalar)
		{
			Vertex3us v;

			v.x = (ushort)(v1.x / scalar);
			v.y = (ushort)(v1.y / scalar);
			v.z = (ushort)(v1.z / scalar);

			return (v);
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(Vertex3us v1, Vertex3us v2)
		{
			return (v1.Equals(v2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(Vertex3us v1, Vertex3us v2)
		{
			return (!v1.Equals(v2));
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to ushort[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3us"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="ushort[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator ushort[](Vertex3us a)
		{
			ushort[] v = new ushort[3];

			v[0] = a.x;
			v[1] = a.y;
			v[2] = a.z;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex2f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3us"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> initialized with the vector components, ignoring the Z component.
		/// </returns>
		public static explicit operator Vertex2f(Vertex3us v)
		{
			return (new Vertex2f(v.X, v.Y));
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3us"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex3f(Vertex3us v)
		{
			return (new Vertex3f(v.X, v.Y, v.Z));
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3us"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex3d(Vertex3us v)
		{
			return (new Vertex3d(v.X, v.Y, v.Z));
		}

		/// <summary>
		/// Cast to Vertex4f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3us"/> to be casted.
		/// </param>
		/// <returns>
		/// A normalized <see cref="Vertex4f"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4f(Vertex3us v)
		{
			return (new Vertex4f(v.X, v.Y, v.Z, 1.0f));
		}

		/// <summary>
		/// Cast to Vertex4d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3us"/> to be casted.
		/// </param>
		/// <returns>
		/// A normalized <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4d(Vertex3us v)
		{
			return (new Vertex4d(v.X, v.Y, v.Z, 1.0f));
		}

		#endregion

		#region Vertex Methods

		/// <summary>
		/// Compute tridimensional vertex module.
		/// </summary>
		/// <returns>
		/// It returns the vertex vector module.
		/// </returns>
		public float Module()
		{
			float x2 = (float)(x * x);
			float y2 = (float)(y * y);
			float z2 = (float)(z * z);

			return ((float)Math.Sqrt(x2 + y2 + z2));
		}

		/// <summary>
		/// Normalize vertex coordinates.
		/// </summary>
		public void Normalize()
		{
			float length = Module();

			if (Math.Abs(length) < Single.Epsilon)
				throw new DivideByZeroException("zero length normalization");

			this /= length;
		}

		/// <summary>
		/// This vertex, but normalized.
		/// </summary>
		public Vertex3us Normalized
		{
			get
			{
				Vertex3us normalized = this;

				normalized.Normalize();

				return (normalized);
			}
		}

		#endregion

		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex3us Zero = new Vertex3us(0);

		/// <summary>
		/// Unit vertex along all axes.
		/// </summary>
		public static readonly Vertex3us One = new Vertex3us(1);

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly Vertex3us UnitX = new Vertex3us(1, 0, 0);

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly Vertex3us UnitY = new Vertex3us(0, 1, 0);

		/// <summary>
		/// Unit vertex along Z axis.
		/// </summary>
		public static readonly Vertex3us UnitZ = new Vertex3us(0, 0, 1);

		#endregion

		#region IVertex3 Implementation

		/// <summary>
		/// Vertex coordinate X, normalized in range [0.0, 1.0].
		/// </summary>
		public float X
		{
			get { return ((float)x / (float)ushort.MaxValue); }
			set
			{
				if (value < 0.0f || value > 1.0)
					throw new InvalidOperationException("value out of range");
				x = (ushort)(value * (float)ushort.MaxValue);
			}
		}

		/// <summary>
		/// Vertex coordinate Y, normalized in range [0.0, 1.0].
		/// </summary>
		public float Y
		{
			get { return ((float)y / (float)ushort.MaxValue); }
			set
			{
				if (value < 0.0f || value > 1.0)
					throw new InvalidOperationException("value out of range");
				y = (ushort)(value * (float)ushort.MaxValue);
			}
		}

		/// <summary>
		/// Vertex coordinate Z, normalized in range [0.0, 1.0].
		/// </summary>
		public float Z
		{
			get { return ((float)z / (float)ushort.MaxValue); }
			set
			{
				if (value < 0.0f || value > 1.0)
					throw new InvalidOperationException("value out of range");
				z = (ushort)(value * (float)ushort.MaxValue);
			}
		}

		#endregion

		#region IVertex Implementation

		/// <summary>
		/// Vertex components indexer.
		/// </summary>
		/// <param name="idx">
		/// A <see cref="UInt32"/> that specify the component index using for accessing to this IVertex component.
		/// </param>
		/// <remarks>
		/// <para>
		/// This indexer returns a single-precision floating-point representation of the vertex component value.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception thrown if <paramref name="idx"/> exceeds the maximum allowed component index.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the set value is outside the representable range of the underlying type.
		/// </exception>s
		public float this[uint idx]
		{
			get
			{
				switch (idx) {
					case 0: return (X);
					case 1: return (Y);
					case 2: return (Z);
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0: X = value; break;
					case 1: Y = value; break;
					case 2: Z = value; break;
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
		}

		#endregion

		#region IEquatable<IVertex3> Implementation

		/// <summary>
		/// Indicates whether the this IVertex3 is equal to another IVertex3.
		/// </summary>
		/// <param name="other">
		/// An IVertex3 to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IVertex3 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(IVertex3 other)
		{
			const float Epsilon = 1e-6f;

			if (ReferenceEquals(null, other))
				return false;

			if (Math.Abs(X - other.X) >= Epsilon)
				return (false);
			if (Math.Abs(Y - other.Y) >= Epsilon)
				return (false);
			if (Math.Abs(Z - other.Z) >= Epsilon)
				return (false);

			return (true);
		}

		/// <summary>
		/// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
		/// </summary>
		/// <param name="obj">
		/// The <see cref="T:System.Object"/> to compare with the current <see cref="T:System.Object"/>.
		/// </param>
		/// <returns>
		/// It returns true if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.
		/// </returns>
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj))
				return (false);
			if (obj.GetType().GetInterface("IVertex3") == null)
				return (false);

			return (Equals((IVertex3)obj));
		}

		/// <summary>
		/// Serves as a hash function for a particular type. <see cref="M:System.Object.GetHashCode"/> is suitable for
		/// use in hashing algorithms and data structures like a hash table.
		/// </summary>
		/// <returns>
		/// A hash code for the current <see cref="T:System.Object"/>.
		/// </returns>
		public override int GetHashCode()
		{
			unchecked {
				int result = x.GetHashCode();
				result = (result * 397) ^ y.GetHashCode();
				result = (result * 397) ^ z.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex3us.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex3us.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0}, {1}, {2}|", x, y, z));
		}

		#endregion
	}

	/// <summary>
	/// Vertex value type (short coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Short, 3)]
	[DebuggerDisplay("Vertex3s: X={x} Y={y} Z={z}")]
	public struct Vertex3s : IVertex3, IEquatable<IVertex3>
	{
		#region Constructors

		/// <summary>
		/// Vertex3s constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="short"/> that specify the value of every component.
		/// </param>
		public Vertex3s(short v) : this(v, v, v) { }

		/// <summary>
		/// Vertex3s constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="short[]"/> that specify the value of every component.
		/// </param>
		public Vertex3s(short[] v) : this(v[0], v[1], v[2]) { }

		/// <summary>
		/// Vertex3s constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="short"/> that specify the X coordinate.
		/// </param>
		/// <param name="y">
		/// A <see cref="short"/> that specify the Y coordinate.
		/// </param>
		/// <param name="z">
		/// A <see cref="short"/> that specify the Z coordinate.
		/// </param>
		public Vertex3s(short x, short y, short z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		/// <summary>
		/// Vertex3s constructor.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Vertex3s"/> that specify the vertex to be copied.
		/// </param>
		public Vertex3s(Vertex3s other) : this(other.x, other.y, other.z) { }

		#endregion

		#region Structure

		/// <summary>
		/// X coordinate for tridimensional vertex.
		/// </summary>
		public short x;

		/// <summary>
		/// Y coordinate for tridimensional vertex.
		/// </summary>
		public short y;

		/// <summary>
		/// Z coordinate for tridimensional vertex.
		/// </summary>
		public short z;

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Negate operator.
		/// </summary>
		/// <param name="v">
		/// The Vertex3s to negate.
		/// </param>
		/// <returns>
		/// It returns the negate of <paramref name="v"/>.
		/// </returns>
		public static Vertex3s operator -(Vertex3s v)
		{
			return (new Vertex3s((short)(-v.x), (short)(-v.y), (short)(-v.z)));
		}

		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3s"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3s"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3s"/> that equals to the addition of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex3s operator +(Vertex3s v1, Vertex3s v2)
		{
			Vertex3s v;

			v.x = (short)(v1.x + v2.x);
			v.y = (short)(v1.y + v2.y);
			v.z = (short)(v1.z + v2.z);

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3s"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3s"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3s"/> that equals to the subtraction of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex3s operator -(Vertex3s v1, Vertex3s v2)
		{
			Vertex3s v;

			v.x = (short)(v1.x - v2.x);
			v.y = (short)(v1.y - v2.y);
			v.z = (short)(v1.z - v2.z);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3s"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3s"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3s operator *(Vertex3s v1, float scalar)
		{
			Vertex3s v;

			v.x = (short)(v1.x * scalar);
			v.y = (short)(v1.y * scalar);
			v.z = (short)(v1.z * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3s"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3s"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3s operator *(Vertex3s v1, double scalar)
		{
			Vertex3s v;

			v.x = (short)(v1.x * scalar);
			v.y = (short)(v1.y * scalar);
			v.z = (short)(v1.z * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3s"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3s"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3s operator /(Vertex3s v1, float scalar)
		{
			Vertex3s v;

			v.x = (short)(v1.x / scalar);
			v.y = (short)(v1.y / scalar);
			v.z = (short)(v1.z / scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3s"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3s"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3s operator /(Vertex3s v1, double scalar)
		{
			Vertex3s v;

			v.x = (short)(v1.x / scalar);
			v.y = (short)(v1.y / scalar);
			v.z = (short)(v1.z / scalar);

			return (v);
		}

		/// <summary>
		/// Dot product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3s"/> representing the left dot product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3s"/> representing the right dot product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3s"/> representing the dot product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static float operator *(Vertex3s v1, Vertex3s v2)
		{
			return (float)(v1.x * v2.x + v1.y * v2.y + v1.z * v2.z);
		}

		/// <summary>
		/// Cross product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3s"/> representing the left cross product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3s"/> representing the right cross product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3s"/> representing the cross product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static Vertex3f operator ^(Vertex3s v1, Vertex3s v2)
		{
			Vertex3f v;

			v.x = (float)(v1.y * v2.z - v1.z * v2.y);
			v.y = (float)(v1.z * v2.x - v1.x * v2.z);
			v.z = (float)(v1.x * v2.y - v1.y * v2.x);

			return (v);
		}

		/// <summary>
		/// Vertex and matrix multiplication.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex3s"/> representing the vertex to be transformed.
		/// </param>
		/// <param name="m">
		/// A <see cref="Matrix4x4"/> representing the transformation matrix.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Vertex3f"/> which represents the transformed vertex.
		/// </returns>
		public static Vertex3f operator *(Vertex3s v, Matrix4x4 m)
		{
			Vertex3f r;

			r.x = (float)((v.x * m[0, 0]) + (v.y * m[0, 1]) + (v.z * m[0, 2]) + m[0, 3]);
			r.y = (float)((v.x * m[1, 1]) + (v.y * m[1, 1]) + (v.z * m[1, 2]) + m[1, 3]);
			r.z = (float)((v.x * m[2, 2]) + (v.y * m[2, 1]) + (v.z * m[2, 2]) + m[2, 3]);

			return (r);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3s"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="short"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3s"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3s operator *(Vertex3s v1, short scalar)
		{
			Vertex3s v;

			v.x = (short)(v1.x * scalar);
			v.y = (short)(v1.y * scalar);
			v.z = (short)(v1.z * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3s"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="short"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3s"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3s operator /(Vertex3s v1, short scalar)
		{
			Vertex3s v;

			v.x = (short)(v1.x / scalar);
			v.y = (short)(v1.y / scalar);
			v.z = (short)(v1.z / scalar);

			return (v);
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(Vertex3s v1, Vertex3s v2)
		{
			return (v1.Equals(v2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(Vertex3s v1, Vertex3s v2)
		{
			return (!v1.Equals(v2));
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to short[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3s"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="short[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator short[](Vertex3s a)
		{
			short[] v = new short[3];

			v[0] = a.x;
			v[1] = a.y;
			v[2] = a.z;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex2f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3s"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> initialized with the vector components, ignoring the Z component.
		/// </returns>
		public static explicit operator Vertex2f(Vertex3s v)
		{
			return (new Vertex2f(v.X, v.Y));
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3s"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex3f(Vertex3s v)
		{
			return (new Vertex3f(v.X, v.Y, v.Z));
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3s"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex3d(Vertex3s v)
		{
			return (new Vertex3d(v.X, v.Y, v.Z));
		}

		/// <summary>
		/// Cast to Vertex4f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3s"/> to be casted.
		/// </param>
		/// <returns>
		/// A normalized <see cref="Vertex4f"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4f(Vertex3s v)
		{
			return (new Vertex4f(v.X, v.Y, v.Z, 1.0f));
		}

		/// <summary>
		/// Cast to Vertex4d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3s"/> to be casted.
		/// </param>
		/// <returns>
		/// A normalized <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4d(Vertex3s v)
		{
			return (new Vertex4d(v.X, v.Y, v.Z, 1.0f));
		}

		#endregion

		#region Vertex Methods

		/// <summary>
		/// Compute tridimensional vertex module.
		/// </summary>
		/// <returns>
		/// It returns the vertex vector module.
		/// </returns>
		public float Module()
		{
			float x2 = (float)(x * x);
			float y2 = (float)(y * y);
			float z2 = (float)(z * z);

			return ((float)Math.Sqrt(x2 + y2 + z2));
		}

		/// <summary>
		/// Normalize vertex coordinates.
		/// </summary>
		public void Normalize()
		{
			float length = Module();

			if (Math.Abs(length) < Single.Epsilon)
				throw new DivideByZeroException("zero length normalization");

			this /= length;
		}

		/// <summary>
		/// This vertex, but normalized.
		/// </summary>
		public Vertex3s Normalized
		{
			get
			{
				Vertex3s normalized = this;

				normalized.Normalize();

				return (normalized);
			}
		}

		#endregion

		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex3s Zero = new Vertex3s(0);

		/// <summary>
		/// Unit vertex along all axes.
		/// </summary>
		public static readonly Vertex3s One = new Vertex3s(1);

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly Vertex3s UnitX = new Vertex3s(1, 0, 0);

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly Vertex3s UnitY = new Vertex3s(0, 1, 0);

		/// <summary>
		/// Unit vertex along Z axis.
		/// </summary>
		public static readonly Vertex3s UnitZ = new Vertex3s(0, 0, 1);

		#endregion

		#region IVertex3 Implementation

		/// <summary>
		/// Vertex coordinate X, normalized in range [-1.0, +1.0].
		/// </summary>
		public float X
		{
			get { return ((float)(x - short.MinValue) / ((long)short.MaxValue - (long)short.MinValue)) * 2.0f - 1.0f; }
			set
			{
				if (value < -1.0f || value > +1.0)
					throw new InvalidOperationException("value out of range");
				x = (short)((value * 0.5f + 0.5f) * ((long)short.MaxValue - (long)short.MinValue) + short.MinValue);
			}
		}

		/// <summary>
		/// Vertex coordinate Y, normalized in range [-1.0, +1.0]..
		/// </summary>
		public float Y
		{
			get { return ((float)(y - short.MinValue) / ((long)short.MaxValue - (long)short.MinValue)) * 2.0f - 1.0f; }
			set
			{
				if (value < -1.0f || value > +1.0)
					throw new InvalidOperationException("value out of range");
				y = (short)((value * 0.5f + 0.5f) * ((long)short.MaxValue - (long)short.MinValue) + short.MinValue);
			}
		}

		/// <summary>
		/// Vertex coordinate Z, normalized in range [-1.0, +1.0]..
		/// </summary>
		public float Z
		{
			get { return ((float)(z - short.MinValue) / ((long)short.MaxValue - (long)short.MinValue)) * 2.0f - 1.0f; }
			set
			{
				if (value < -1.0f || value > +1.0)
					throw new InvalidOperationException("value out of range");
				z = (short)((value * 0.5f + 0.5f) * ((long)short.MaxValue - (long)short.MinValue) + short.MinValue);
			}
		}

		#endregion

		#region IVertex Implementation

		/// <summary>
		/// Vertex components indexer.
		/// </summary>
		/// <param name="idx">
		/// A <see cref="UInt32"/> that specify the component index using for accessing to this IVertex component.
		/// </param>
		/// <remarks>
		/// <para>
		/// This indexer returns a single-precision floating-point representation of the vertex component value.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception thrown if <paramref name="idx"/> exceeds the maximum allowed component index.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the set value is outside the representable range of the underlying type.
		/// </exception>s
		public float this[uint idx]
		{
			get
			{
				switch (idx) {
					case 0: return (X);
					case 1: return (Y);
					case 2: return (Z);
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0: X = value; break;
					case 1: Y = value; break;
					case 2: Z = value; break;
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
		}

		#endregion

		#region IEquatable<IVertex3> Implementation

		/// <summary>
		/// Indicates whether the this IVertex3 is equal to another IVertex3.
		/// </summary>
		/// <param name="other">
		/// An IVertex3 to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IVertex3 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(IVertex3 other)
		{
			const float Epsilon = 1e-6f;

			if (ReferenceEquals(null, other))
				return false;

			if (Math.Abs(X - other.X) >= Epsilon)
				return (false);
			if (Math.Abs(Y - other.Y) >= Epsilon)
				return (false);
			if (Math.Abs(Z - other.Z) >= Epsilon)
				return (false);

			return (true);
		}

		/// <summary>
		/// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
		/// </summary>
		/// <param name="obj">
		/// The <see cref="T:System.Object"/> to compare with the current <see cref="T:System.Object"/>.
		/// </param>
		/// <returns>
		/// It returns true if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.
		/// </returns>
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj))
				return (false);
			if (obj.GetType().GetInterface("IVertex3") == null)
				return (false);

			return (Equals((IVertex3)obj));
		}

		/// <summary>
		/// Serves as a hash function for a particular type. <see cref="M:System.Object.GetHashCode"/> is suitable for
		/// use in hashing algorithms and data structures like a hash table.
		/// </summary>
		/// <returns>
		/// A hash code for the current <see cref="T:System.Object"/>.
		/// </returns>
		public override int GetHashCode()
		{
			unchecked {
				int result = x.GetHashCode();
				result = (result * 397) ^ y.GetHashCode();
				result = (result * 397) ^ z.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex3s.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex3s.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0}, {1}, {2}|", x, y, z));
		}

		#endregion
	}

	/// <summary>
	/// Vertex value type (uint coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.UInt, 3)]
	[DebuggerDisplay("Vertex3ui: X={x} Y={y} Z={z}")]
	public struct Vertex3ui : IVertex3, IEquatable<IVertex3>
	{
		#region Constructors

		/// <summary>
		/// Vertex3ui constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="uint"/> that specify the value of every component.
		/// </param>
		public Vertex3ui(uint v) : this(v, v, v) { }

		/// <summary>
		/// Vertex3ui constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="uint[]"/> that specify the value of every component.
		/// </param>
		public Vertex3ui(uint[] v) : this(v[0], v[1], v[2]) { }

		/// <summary>
		/// Vertex3ui constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="uint"/> that specify the X coordinate.
		/// </param>
		/// <param name="y">
		/// A <see cref="uint"/> that specify the Y coordinate.
		/// </param>
		/// <param name="z">
		/// A <see cref="uint"/> that specify the Z coordinate.
		/// </param>
		public Vertex3ui(uint x, uint y, uint z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		/// <summary>
		/// Vertex3ui constructor.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Vertex3ui"/> that specify the vertex to be copied.
		/// </param>
		public Vertex3ui(Vertex3ui other) : this(other.x, other.y, other.z) { }

		#endregion

		#region Structure

		/// <summary>
		/// X coordinate for tridimensional vertex.
		/// </summary>
		public uint x;

		/// <summary>
		/// Y coordinate for tridimensional vertex.
		/// </summary>
		public uint y;

		/// <summary>
		/// Z coordinate for tridimensional vertex.
		/// </summary>
		public uint z;

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3ui"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3ui"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3ui"/> that equals to the addition of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex3ui operator +(Vertex3ui v1, Vertex3ui v2)
		{
			Vertex3ui v;

			v.x = (uint)(v1.x + v2.x);
			v.y = (uint)(v1.y + v2.y);
			v.z = (uint)(v1.z + v2.z);

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3ui"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3ui"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3ui"/> that equals to the subtraction of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex3ui operator -(Vertex3ui v1, Vertex3ui v2)
		{
			Vertex3ui v;

			v.x = (uint)(v1.x - v2.x);
			v.y = (uint)(v1.y - v2.y);
			v.z = (uint)(v1.z - v2.z);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3ui"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3ui"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3ui operator *(Vertex3ui v1, float scalar)
		{
			Vertex3ui v;

			v.x = (uint)(v1.x * scalar);
			v.y = (uint)(v1.y * scalar);
			v.z = (uint)(v1.z * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3ui"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3ui"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3ui operator *(Vertex3ui v1, double scalar)
		{
			Vertex3ui v;

			v.x = (uint)(v1.x * scalar);
			v.y = (uint)(v1.y * scalar);
			v.z = (uint)(v1.z * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3ui"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3ui"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3ui operator /(Vertex3ui v1, float scalar)
		{
			Vertex3ui v;

			v.x = (uint)(v1.x / scalar);
			v.y = (uint)(v1.y / scalar);
			v.z = (uint)(v1.z / scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3ui"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3ui"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3ui operator /(Vertex3ui v1, double scalar)
		{
			Vertex3ui v;

			v.x = (uint)(v1.x / scalar);
			v.y = (uint)(v1.y / scalar);
			v.z = (uint)(v1.z / scalar);

			return (v);
		}

		/// <summary>
		/// Dot product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3ui"/> representing the left dot product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3ui"/> representing the right dot product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3ui"/> representing the dot product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static float operator *(Vertex3ui v1, Vertex3ui v2)
		{
			return (float)(v1.x * v2.x + v1.y * v2.y + v1.z * v2.z);
		}

		/// <summary>
		/// Cross product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3ui"/> representing the left cross product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3ui"/> representing the right cross product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3ui"/> representing the cross product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static Vertex3f operator ^(Vertex3ui v1, Vertex3ui v2)
		{
			Vertex3f v;

			v.x = (float)(v1.y * v2.z - v1.z * v2.y);
			v.y = (float)(v1.z * v2.x - v1.x * v2.z);
			v.z = (float)(v1.x * v2.y - v1.y * v2.x);

			return (v);
		}

		/// <summary>
		/// Vertex and matrix multiplication.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex3ui"/> representing the vertex to be transformed.
		/// </param>
		/// <param name="m">
		/// A <see cref="Matrix4x4"/> representing the transformation matrix.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Vertex3f"/> which represents the transformed vertex.
		/// </returns>
		public static Vertex3f operator *(Vertex3ui v, Matrix4x4 m)
		{
			Vertex3f r;

			r.x = (float)((v.x * m[0, 0]) + (v.y * m[0, 1]) + (v.z * m[0, 2]) + m[0, 3]);
			r.y = (float)((v.x * m[1, 1]) + (v.y * m[1, 1]) + (v.z * m[1, 2]) + m[1, 3]);
			r.z = (float)((v.x * m[2, 2]) + (v.y * m[2, 1]) + (v.z * m[2, 2]) + m[2, 3]);

			return (r);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3ui"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="uint"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3ui"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3ui operator *(Vertex3ui v1, uint scalar)
		{
			Vertex3ui v;

			v.x = (uint)(v1.x * scalar);
			v.y = (uint)(v1.y * scalar);
			v.z = (uint)(v1.z * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3ui"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="uint"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3ui"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3ui operator /(Vertex3ui v1, uint scalar)
		{
			Vertex3ui v;

			v.x = (uint)(v1.x / scalar);
			v.y = (uint)(v1.y / scalar);
			v.z = (uint)(v1.z / scalar);

			return (v);
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(Vertex3ui v1, Vertex3ui v2)
		{
			return (v1.Equals(v2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(Vertex3ui v1, Vertex3ui v2)
		{
			return (!v1.Equals(v2));
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to uint[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3ui"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="uint[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator uint[](Vertex3ui a)
		{
			uint[] v = new uint[3];

			v[0] = a.x;
			v[1] = a.y;
			v[2] = a.z;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex2f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3ui"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> initialized with the vector components, ignoring the Z component.
		/// </returns>
		public static explicit operator Vertex2f(Vertex3ui v)
		{
			return (new Vertex2f(v.X, v.Y));
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3ui"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex3f(Vertex3ui v)
		{
			return (new Vertex3f(v.X, v.Y, v.Z));
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3ui"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex3d(Vertex3ui v)
		{
			return (new Vertex3d(v.X, v.Y, v.Z));
		}

		/// <summary>
		/// Cast to Vertex4f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3ui"/> to be casted.
		/// </param>
		/// <returns>
		/// A normalized <see cref="Vertex4f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex4f(Vertex3ui v)
		{
			return (new Vertex4f(v.X, v.Y, v.Z, 1.0f));
		}

		/// <summary>
		/// Cast to Vertex4d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3ui"/> to be casted.
		/// </param>
		/// <returns>
		/// A normalized <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4d(Vertex3ui v)
		{
			return (new Vertex4d(v.X, v.Y, v.Z, 1.0f));
		}

		#endregion

		#region Vertex Methods

		/// <summary>
		/// Compute tridimensional vertex module.
		/// </summary>
		/// <returns>
		/// It returns the vertex vector module.
		/// </returns>
		public float Module()
		{
			float x2 = (float)(x * x);
			float y2 = (float)(y * y);
			float z2 = (float)(z * z);

			return ((float)Math.Sqrt(x2 + y2 + z2));
		}

		/// <summary>
		/// Normalize vertex coordinates.
		/// </summary>
		public void Normalize()
		{
			float length = Module();

			if (Math.Abs(length) < Single.Epsilon)
				throw new DivideByZeroException("zero length normalization");

			this /= length;
		}

		/// <summary>
		/// This vertex, but normalized.
		/// </summary>
		public Vertex3ui Normalized
		{
			get
			{
				Vertex3ui normalized = this;

				normalized.Normalize();

				return (normalized);
			}
		}

		#endregion

		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex3ui Zero = new Vertex3ui(0);

		/// <summary>
		/// Unit vertex along all axes.
		/// </summary>
		public static readonly Vertex3ui One = new Vertex3ui(1);

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly Vertex3ui UnitX = new Vertex3ui(1, 0, 0);

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly Vertex3ui UnitY = new Vertex3ui(0, 1, 0);

		/// <summary>
		/// Unit vertex along Z axis.
		/// </summary>
		public static readonly Vertex3ui UnitZ = new Vertex3ui(0, 0, 1);

		#endregion

		#region IVertex3 Implementation

		/// <summary>
		/// Vertex coordinate X, normalized in range [0.0, 1.0].
		/// </summary>
		public float X
		{
			get { return ((float)x / (float)uint.MaxValue); }
			set
			{
				if (value < 0.0f || value > 1.0)
					throw new InvalidOperationException("value out of range");
				x = (uint)(value * (float)uint.MaxValue);
			}
		}

		/// <summary>
		/// Vertex coordinate Y, normalized in range [0.0, 1.0].
		/// </summary>
		public float Y
		{
			get { return ((float)y / (float)uint.MaxValue); }
			set
			{
				if (value < 0.0f || value > 1.0)
					throw new InvalidOperationException("value out of range");
				y = (uint)(value * (float)uint.MaxValue);
			}
		}

		/// <summary>
		/// Vertex coordinate Z, normalized in range [0.0, 1.0].
		/// </summary>
		public float Z
		{
			get { return ((float)z / (float)uint.MaxValue); }
			set
			{
				if (value < 0.0f || value > 1.0)
					throw new InvalidOperationException("value out of range");
				z = (uint)(value * (float)uint.MaxValue);
			}
		}

		#endregion

		#region IVertex Implementation

		/// <summary>
		/// Vertex components indexer.
		/// </summary>
		/// <param name="idx">
		/// A <see cref="UInt32"/> that specify the component index using for accessing to this IVertex component.
		/// </param>
		/// <remarks>
		/// <para>
		/// This indexer returns a single-precision floating-point representation of the vertex component value.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception thrown if <paramref name="idx"/> exceeds the maximum allowed component index.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the set value is outside the representable range of the underlying type.
		/// </exception>s
		public float this[uint idx]
		{
			get
			{
				switch (idx) {
					case 0: return (X);
					case 1: return (Y);
					case 2: return (Z);
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0: X = value; break;
					case 1: Y = value; break;
					case 2: Z = value; break;
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
		}

		#endregion

		#region IEquatable<IVertex3> Implementation

		/// <summary>
		/// Indicates whether the this IVertex3 is equal to another IVertex3.
		/// </summary>
		/// <param name="other">
		/// An IVertex3 to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IVertex3 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(IVertex3 other)
		{
			const float Epsilon = 1e-6f;

			if (ReferenceEquals(null, other))
				return false;

			if (Math.Abs(X - other.X) >= Epsilon)
				return (false);
			if (Math.Abs(Y - other.Y) >= Epsilon)
				return (false);
			if (Math.Abs(Z - other.Z) >= Epsilon)
				return (false);

			return (true);
		}

		/// <summary>
		/// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
		/// </summary>
		/// <param name="obj">
		/// The <see cref="T:System.Object"/> to compare with the current <see cref="T:System.Object"/>.
		/// </param>
		/// <returns>
		/// It returns true if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.
		/// </returns>
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj))
				return (false);
			if (obj.GetType().GetInterface("IVertex3") == null)
				return (false);

			return (Equals((IVertex3)obj));
		}

		/// <summary>
		/// Serves as a hash function for a particular type. <see cref="M:System.Object.GetHashCode"/> is suitable for
		/// use in hashing algorithms and data structures like a hash table.
		/// </summary>
		/// <returns>
		/// A hash code for the current <see cref="T:System.Object"/>.
		/// </returns>
		public override int GetHashCode()
		{
			unchecked {
				int result = x.GetHashCode();
				result = (result * 397) ^ y.GetHashCode();
				result = (result * 397) ^ z.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex3ui.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex3ui.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0}, {1}, {2}|", x, y, z));
		}

		#endregion
	}

	/// <summary>
	/// Vertex value type (int coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Int, 3)]
	[DebuggerDisplay("Vertex3i: X={x} Y={y} Z={z}")]
	public struct Vertex3i : IVertex3, IEquatable<IVertex3>
	{
		#region Constructors

		/// <summary>
		/// Vertex3i constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="int"/> that specify the value of every component.
		/// </param>
		public Vertex3i(int v) : this(v, v, v) { }

		/// <summary>
		/// Vertex3i constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="int[]"/> that specify the value of every component.
		/// </param>
		public Vertex3i(int[] v) : this(v[0], v[1], v[2]) { }

		/// <summary>
		/// Vertex3i constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="int"/> that specify the X coordinate.
		/// </param>
		/// <param name="y">
		/// A <see cref="int"/> that specify the Y coordinate.
		/// </param>
		/// <param name="z">
		/// A <see cref="int"/> that specify the Z coordinate.
		/// </param>
		public Vertex3i(int x, int y, int z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		/// <summary>
		/// Vertex3i constructor.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Vertex3i"/> that specify the vertex to be copied.
		/// </param>
		public Vertex3i(Vertex3i other) : this(other.x, other.y, other.z) { }

		#endregion

		#region Structure

		/// <summary>
		/// X coordinate for tridimensional vertex.
		/// </summary>
		public int x;

		/// <summary>
		/// Y coordinate for tridimensional vertex.
		/// </summary>
		public int y;

		/// <summary>
		/// Z coordinate for tridimensional vertex.
		/// </summary>
		public int z;

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Negate operator.
		/// </summary>
		/// <param name="v">
		/// The Vertex3i to negate.
		/// </param>
		/// <returns>
		/// It returns the negate of <paramref name="v"/>.
		/// </returns>
		public static Vertex3i operator -(Vertex3i v)
		{
			return (new Vertex3i((int)(-v.x), (int)(-v.y), (int)(-v.z)));
		}

		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3i"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3i"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3i"/> that equals to the addition of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex3i operator +(Vertex3i v1, Vertex3i v2)
		{
			Vertex3i v;

			v.x = (int)(v1.x + v2.x);
			v.y = (int)(v1.y + v2.y);
			v.z = (int)(v1.z + v2.z);

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3i"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3i"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3i"/> that equals to the subtraction of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex3i operator -(Vertex3i v1, Vertex3i v2)
		{
			Vertex3i v;

			v.x = (int)(v1.x - v2.x);
			v.y = (int)(v1.y - v2.y);
			v.z = (int)(v1.z - v2.z);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3i"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3i"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3i operator *(Vertex3i v1, float scalar)
		{
			Vertex3i v;

			v.x = (int)(v1.x * scalar);
			v.y = (int)(v1.y * scalar);
			v.z = (int)(v1.z * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3i"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3i"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3i operator *(Vertex3i v1, double scalar)
		{
			Vertex3i v;

			v.x = (int)(v1.x * scalar);
			v.y = (int)(v1.y * scalar);
			v.z = (int)(v1.z * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3i"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3i"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3i operator /(Vertex3i v1, float scalar)
		{
			Vertex3i v;

			v.x = (int)(v1.x / scalar);
			v.y = (int)(v1.y / scalar);
			v.z = (int)(v1.z / scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3i"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3i"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3i operator /(Vertex3i v1, double scalar)
		{
			Vertex3i v;

			v.x = (int)(v1.x / scalar);
			v.y = (int)(v1.y / scalar);
			v.z = (int)(v1.z / scalar);

			return (v);
		}

		/// <summary>
		/// Dot product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3i"/> representing the left dot product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3i"/> representing the right dot product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3i"/> representing the dot product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static float operator *(Vertex3i v1, Vertex3i v2)
		{
			return (float)(v1.x * v2.x + v1.y * v2.y + v1.z * v2.z);
		}

		/// <summary>
		/// Cross product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3i"/> representing the left cross product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3i"/> representing the right cross product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3i"/> representing the cross product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static Vertex3f operator ^(Vertex3i v1, Vertex3i v2)
		{
			Vertex3f v;

			v.x = (float)(v1.y * v2.z - v1.z * v2.y);
			v.y = (float)(v1.z * v2.x - v1.x * v2.z);
			v.z = (float)(v1.x * v2.y - v1.y * v2.x);

			return (v);
		}

		/// <summary>
		/// Vertex and matrix multiplication.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex3i"/> representing the vertex to be transformed.
		/// </param>
		/// <param name="m">
		/// A <see cref="Matrix4x4"/> representing the transformation matrix.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Vertex3f"/> which represents the transformed vertex.
		/// </returns>
		public static Vertex3f operator *(Vertex3i v, Matrix4x4 m)
		{
			Vertex3f r;

			r.x = (float)((v.x * m[0, 0]) + (v.y * m[0, 1]) + (v.z * m[0, 2]) + m[0, 3]);
			r.y = (float)((v.x * m[1, 1]) + (v.y * m[1, 1]) + (v.z * m[1, 2]) + m[1, 3]);
			r.z = (float)((v.x * m[2, 2]) + (v.y * m[2, 1]) + (v.z * m[2, 2]) + m[2, 3]);

			return (r);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3i"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="int"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3i"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3i operator *(Vertex3i v1, int scalar)
		{
			Vertex3i v;

			v.x = (int)(v1.x * scalar);
			v.y = (int)(v1.y * scalar);
			v.z = (int)(v1.z * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3i"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="int"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3i"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3i operator /(Vertex3i v1, int scalar)
		{
			Vertex3i v;

			v.x = (int)(v1.x / scalar);
			v.y = (int)(v1.y / scalar);
			v.z = (int)(v1.z / scalar);

			return (v);
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(Vertex3i v1, Vertex3i v2)
		{
			return (v1.Equals(v2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(Vertex3i v1, Vertex3i v2)
		{
			return (!v1.Equals(v2));
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to int[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3i"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="int[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator int[](Vertex3i a)
		{
			int[] v = new int[3];

			v[0] = a.x;
			v[1] = a.y;
			v[2] = a.z;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex2f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3i"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> initialized with the vector components, ignoring the Z component.
		/// </returns>
		public static explicit operator Vertex2f(Vertex3i v)
		{
			return (new Vertex2f(v.X, v.Y));
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3i"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex3f(Vertex3i v)
		{
			return (new Vertex3f(v.X, v.Y, v.Z));
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3i"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex3d(Vertex3i v)
		{
			return (new Vertex3d(v.X, v.Y, v.Z));
		}

		/// <summary>
		/// Cast to Vertex4f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3i"/> to be casted.
		/// </param>
		/// <returns>
		/// A normalized <see cref="Vertex4f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex4f(Vertex3i v)
		{
			return (new Vertex4f(v.X, v.Y, v.Z, 1.0f));
		}

		/// <summary>
		/// Cast to Vertex4d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3i"/> to be casted.
		/// </param>
		/// <returns>
		/// A normalized <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4d(Vertex3i v)
		{
			return (new Vertex4d(v.X, v.Y, v.Z, 1.0f));
		}

		#endregion

		#region Vertex Methods

		/// <summary>
		/// Compute tridimensional vertex module.
		/// </summary>
		/// <returns>
		/// It returns the vertex vector module.
		/// </returns>
		public float Module()
		{
			float x2 = (float)(x * x);
			float y2 = (float)(y * y);
			float z2 = (float)(z * z);

			return ((float)Math.Sqrt(x2 + y2 + z2));
		}

		/// <summary>
		/// Normalize vertex coordinates.
		/// </summary>
		public void Normalize()
		{
			float length = Module();

			if (Math.Abs(length) < Single.Epsilon)
				throw new DivideByZeroException("zero length normalization");

			this /= length;
		}

		/// <summary>
		/// This vertex, but normalized.
		/// </summary>
		public Vertex3i Normalized
		{
			get
			{
				Vertex3i normalized = this;

				normalized.Normalize();

				return (normalized);
			}
		}

		#endregion

		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex3i Zero = new Vertex3i(0);

		/// <summary>
		/// Unit vertex along all axes.
		/// </summary>
		public static readonly Vertex3i One = new Vertex3i(1);

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly Vertex3i UnitX = new Vertex3i(1, 0, 0);

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly Vertex3i UnitY = new Vertex3i(0, 1, 0);

		/// <summary>
		/// Unit vertex along Z axis.
		/// </summary>
		public static readonly Vertex3i UnitZ = new Vertex3i(0, 0, 1);

		#endregion

		#region IVertex3 Implementation

		/// <summary>
		/// Vertex coordinate X, normalized in range [-1.0, +1.0].
		/// </summary>
		public float X
		{
			get { return ((float)(x - int.MinValue) / ((long)int.MaxValue - (long)int.MinValue)) * 2.0f - 1.0f; }
			set
			{
				if (value < -1.0f || value > +1.0)
					throw new InvalidOperationException("value out of range");
				x = (int)((value * 0.5f + 0.5f) * ((long)int.MaxValue - (long)int.MinValue) + int.MinValue);
			}
		}

		/// <summary>
		/// Vertex coordinate Y, normalized in range [-1.0, +1.0]..
		/// </summary>
		public float Y
		{
			get { return ((float)(y - int.MinValue) / ((long)int.MaxValue - (long)int.MinValue)) * 2.0f - 1.0f; }
			set
			{
				if (value < -1.0f || value > +1.0)
					throw new InvalidOperationException("value out of range");
				y = (int)((value * 0.5f + 0.5f) * ((long)int.MaxValue - (long)int.MinValue) + int.MinValue);
			}
		}

		/// <summary>
		/// Vertex coordinate Z, normalized in range [-1.0, +1.0]..
		/// </summary>
		public float Z
		{
			get { return ((float)(z - int.MinValue) / ((long)int.MaxValue - (long)int.MinValue)) * 2.0f - 1.0f; }
			set
			{
				if (value < -1.0f || value > +1.0)
					throw new InvalidOperationException("value out of range");
				z = (int)((value * 0.5f + 0.5f) * ((long)int.MaxValue - (long)int.MinValue) + int.MinValue);
			}
		}

		#endregion

		#region IVertex Implementation

		/// <summary>
		/// Vertex components indexer.
		/// </summary>
		/// <param name="idx">
		/// A <see cref="UInt32"/> that specify the component index using for accessing to this IVertex component.
		/// </param>
		/// <remarks>
		/// <para>
		/// This indexer returns a single-precision floating-point representation of the vertex component value.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception thrown if <paramref name="idx"/> exceeds the maximum allowed component index.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the set value is outside the representable range of the underlying type.
		/// </exception>s
		public float this[uint idx]
		{
			get
			{
				switch (idx) {
					case 0: return (X);
					case 1: return (Y);
					case 2: return (Z);
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0: X = value; break;
					case 1: Y = value; break;
					case 2: Z = value; break;
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
		}

		#endregion

		#region IEquatable<IVertex3> Implementation

		/// <summary>
		/// Indicates whether the this IVertex3 is equal to another IVertex3.
		/// </summary>
		/// <param name="other">
		/// An IVertex3 to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IVertex3 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(IVertex3 other)
		{
			const float Epsilon = 1e-6f;

			if (ReferenceEquals(null, other))
				return false;

			if (Math.Abs(X - other.X) >= Epsilon)
				return (false);
			if (Math.Abs(Y - other.Y) >= Epsilon)
				return (false);
			if (Math.Abs(Z - other.Z) >= Epsilon)
				return (false);

			return (true);
		}

		/// <summary>
		/// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
		/// </summary>
		/// <param name="obj">
		/// The <see cref="T:System.Object"/> to compare with the current <see cref="T:System.Object"/>.
		/// </param>
		/// <returns>
		/// It returns true if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.
		/// </returns>
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj))
				return (false);
			if (obj.GetType().GetInterface("IVertex3") == null)
				return (false);

			return (Equals((IVertex3)obj));
		}

		/// <summary>
		/// Serves as a hash function for a particular type. <see cref="M:System.Object.GetHashCode"/> is suitable for
		/// use in hashing algorithms and data structures like a hash table.
		/// </summary>
		/// <returns>
		/// A hash code for the current <see cref="T:System.Object"/>.
		/// </returns>
		public override int GetHashCode()
		{
			unchecked {
				int result = x.GetHashCode();
				result = (result * 397) ^ y.GetHashCode();
				result = (result * 397) ^ z.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex3i.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex3i.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0}, {1}, {2}|", x, y, z));
		}

		#endregion
	}

	/// <summary>
	/// Vertex value type (float coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Float, 3)]
	[DebuggerDisplay("Vertex3f: X={x} Y={y} Z={z}")]
	public struct Vertex3f : IVertex3, IEquatable<IVertex3>
	{
		#region Constructors

		/// <summary>
		/// Vertex3f constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="float"/> that specify the value of every component.
		/// </param>
		public Vertex3f(float v) : this(v, v, v) { }

		/// <summary>
		/// Vertex3f constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="float[]"/> that specify the value of every component.
		/// </param>
		public Vertex3f(float[] v) : this(v[0], v[1], v[2]) { }

		/// <summary>
		/// Vertex3f constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="float"/> that specify the X coordinate.
		/// </param>
		/// <param name="y">
		/// A <see cref="float"/> that specify the Y coordinate.
		/// </param>
		/// <param name="z">
		/// A <see cref="float"/> that specify the Z coordinate.
		/// </param>
		public Vertex3f(float x, float y, float z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		/// <summary>
		/// Vertex3f constructor.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Vertex3f"/> that specify the vertex to be copied.
		/// </param>
		public Vertex3f(Vertex3f other) : this(other.x, other.y, other.z) { }

		#endregion

		#region Structure

		/// <summary>
		/// X coordinate for tridimensional vertex.
		/// </summary>
		public float x;

		/// <summary>
		/// Y coordinate for tridimensional vertex.
		/// </summary>
		public float y;

		/// <summary>
		/// Z coordinate for tridimensional vertex.
		/// </summary>
		public float z;

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Negate operator.
		/// </summary>
		/// <param name="v">
		/// The Vertex3f to negate.
		/// </param>
		/// <returns>
		/// It returns the negate of <paramref name="v"/>.
		/// </returns>
		public static Vertex3f operator -(Vertex3f v)
		{
			return (new Vertex3f((float)(-v.x), (float)(-v.y), (float)(-v.z)));
		}

		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3f"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3f"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> that equals to the addition of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex3f operator +(Vertex3f v1, Vertex3f v2)
		{
			Vertex3f v;

			v.x = (float)(v1.x + v2.x);
			v.y = (float)(v1.y + v2.y);
			v.z = (float)(v1.z + v2.z);

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3f"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3f"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> that equals to the subtraction of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex3f operator -(Vertex3f v1, Vertex3f v2)
		{
			Vertex3f v;

			v.x = (float)(v1.x - v2.x);
			v.y = (float)(v1.y - v2.y);
			v.z = (float)(v1.z - v2.z);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3f"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3f operator *(Vertex3f v1, float scalar)
		{
			Vertex3f v;

			v.x = (float)(v1.x * scalar);
			v.y = (float)(v1.y * scalar);
			v.z = (float)(v1.z * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3f"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3f operator *(Vertex3f v1, double scalar)
		{
			Vertex3f v;

			v.x = (float)(v1.x * scalar);
			v.y = (float)(v1.y * scalar);
			v.z = (float)(v1.z * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3f"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3f operator /(Vertex3f v1, float scalar)
		{
			Vertex3f v;

			v.x = (float)(v1.x / scalar);
			v.y = (float)(v1.y / scalar);
			v.z = (float)(v1.z / scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3f"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3f operator /(Vertex3f v1, double scalar)
		{
			Vertex3f v;

			v.x = (float)(v1.x / scalar);
			v.y = (float)(v1.y / scalar);
			v.z = (float)(v1.z / scalar);

			return (v);
		}

		/// <summary>
		/// Dot product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3f"/> representing the left dot product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3f"/> representing the right dot product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> representing the dot product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static float operator *(Vertex3f v1, Vertex3f v2)
		{
			return (float)(v1.x * v2.x + v1.y * v2.y + v1.z * v2.z);
		}

		/// <summary>
		/// Cross product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3f"/> representing the left cross product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3f"/> representing the right cross product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> representing the cross product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static Vertex3f operator ^(Vertex3f v1, Vertex3f v2)
		{
			Vertex3f v;

			v.x = (float)(v1.y * v2.z - v1.z * v2.y);
			v.y = (float)(v1.z * v2.x - v1.x * v2.z);
			v.z = (float)(v1.x * v2.y - v1.y * v2.x);

			return (v);
		}

		/// <summary>
		/// Vertex and matrix multiplication.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex3f"/> representing the vertex to be transformed.
		/// </param>
		/// <param name="m">
		/// A <see cref="Matrix4x4"/> representing the transformation matrix.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Vertex3f"/> which represents the transformed vertex.
		/// </returns>
		public static Vertex3f operator *(Vertex3f v, Matrix4x4 m)
		{
			Vertex3f r;

			r.x = (float)((v.x * m[0, 0]) + (v.y * m[0, 1]) + (v.z * m[0, 2]) + m[0, 3]);
			r.y = (float)((v.x * m[1, 1]) + (v.y * m[1, 1]) + (v.z * m[1, 2]) + m[1, 3]);
			r.z = (float)((v.x * m[2, 2]) + (v.y * m[2, 1]) + (v.z * m[2, 2]) + m[2, 3]);

			return (r);
		}


		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(Vertex3f v1, Vertex3f v2)
		{
			return (v1.Equals(v2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(Vertex3f v1, Vertex3f v2)
		{
			return (!v1.Equals(v2));
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to float[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3f"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="float[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator float[](Vertex3f a)
		{
			float[] v = new float[3];

			v[0] = a.x;
			v[1] = a.y;
			v[2] = a.z;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex2f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3f"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> initialized with the vector components, ignoring the Z component.
		/// </returns>
		public static explicit operator Vertex2f(Vertex3f v)
		{
			return (new Vertex2f(v.X, v.Y));
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3f"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex3d(Vertex3f v)
		{
			return (new Vertex3d(v.X, v.Y, v.Z));
		}

		/// <summary>
		/// Cast to Vertex4f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3f"/> to be casted.
		/// </param>
		/// <returns>
		/// A normalized <see cref="Vertex4f"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4f(Vertex3f v)
		{
			return (new Vertex4f(v.X, v.Y, v.Z, 1.0f));
		}

		/// <summary>
		/// Cast to Vertex4d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3f"/> to be casted.
		/// </param>
		/// <returns>
		/// A normalized <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4d(Vertex3f v)
		{
			return (new Vertex4d(v.X, v.Y, v.Z, 1.0f));
		}

		#endregion

		#region Vertex Methods

		/// <summary>
		/// Compute tridimensional vertex module.
		/// </summary>
		/// <returns>
		/// It returns the vertex vector module.
		/// </returns>
		public float Module()
		{
			float x2 = (float)(x * x);
			float y2 = (float)(y * y);
			float z2 = (float)(z * z);

			return ((float)Math.Sqrt(x2 + y2 + z2));
		}

		/// <summary>
		/// Normalize vertex coordinates.
		/// </summary>
		public void Normalize()
		{
			float length = Module();

			if (Math.Abs(length) < Single.Epsilon)
				throw new DivideByZeroException("zero length normalization");

			this /= length;
		}

		/// <summary>
		/// This vertex, but normalized.
		/// </summary>
		public Vertex3f Normalized
		{
			get
			{
				Vertex3f normalized = this;

				normalized.Normalize();

				return (normalized);
			}
		}

		#endregion

		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex3f Zero = new Vertex3f(0.0f);

		/// <summary>
		/// Unit vertex along all axes.
		/// </summary>
		public static readonly Vertex3f One = new Vertex3f(1.0f);

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly Vertex3f UnitX = new Vertex3f(1.0f, 0.0f, 0.0f);

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly Vertex3f UnitY = new Vertex3f(0.0f, 1.0f, 0.0f);

		/// <summary>
		/// Unit vertex along Z axis.
		/// </summary>
		public static readonly Vertex3f UnitZ = new Vertex3f(0.0f, 0.0f, 1.0f);

		#endregion

		#region IVertex3 Implementation

		/// <summary>
		/// Vertex coordinate X, unclamped range.
		/// </summary>
		public float X
		{
			get { return ((float)x); }
			set { x = (float)value; }
		}

		/// <summary>
		/// Vertex coordinate Y, unclamped range.
		/// </summary>
		public float Y
		{
			get { return ((float)y); }
			set { y = (float)value; }
		}

		/// <summary>
		/// Vertex coordinate Z, unclamped range.
		/// </summary>
		public float Z
		{
			get { return ((float)z); }
			set { z = (float)value; }
		}

		#endregion

		#region IVertex Implementation

		/// <summary>
		/// Vertex components indexer.
		/// </summary>
		/// <param name="idx">
		/// A <see cref="UInt32"/> that specify the component index using for accessing to this IVertex component.
		/// </param>
		/// <remarks>
		/// <para>
		/// This indexer returns a single-precision floating-point representation of the vertex component value.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception thrown if <paramref name="idx"/> exceeds the maximum allowed component index.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the set value is outside the representable range of the underlying type.
		/// </exception>s
		public float this[uint idx]
		{
			get
			{
				switch (idx) {
					case 0: return (X);
					case 1: return (Y);
					case 2: return (Z);
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0: X = value; break;
					case 1: Y = value; break;
					case 2: Z = value; break;
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
		}

		#endregion

		#region IEquatable<IVertex3> Implementation

		/// <summary>
		/// Indicates whether the this IVertex3 is equal to another IVertex3.
		/// </summary>
		/// <param name="other">
		/// An IVertex3 to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IVertex3 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(IVertex3 other)
		{
			const float Epsilon = 1e-6f;

			if (ReferenceEquals(null, other))
				return false;

			if (Math.Abs(X - other.X) >= Epsilon)
				return (false);
			if (Math.Abs(Y - other.Y) >= Epsilon)
				return (false);
			if (Math.Abs(Z - other.Z) >= Epsilon)
				return (false);

			return (true);
		}

		/// <summary>
		/// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
		/// </summary>
		/// <param name="obj">
		/// The <see cref="T:System.Object"/> to compare with the current <see cref="T:System.Object"/>.
		/// </param>
		/// <returns>
		/// It returns true if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.
		/// </returns>
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj))
				return (false);
			if (obj.GetType().GetInterface("IVertex3") == null)
				return (false);

			return (Equals((IVertex3)obj));
		}

		/// <summary>
		/// Serves as a hash function for a particular type. <see cref="M:System.Object.GetHashCode"/> is suitable for
		/// use in hashing algorithms and data structures like a hash table.
		/// </summary>
		/// <returns>
		/// A hash code for the current <see cref="T:System.Object"/>.
		/// </returns>
		public override int GetHashCode()
		{
			unchecked {
				int result = x.GetHashCode();
				result = (result * 397) ^ y.GetHashCode();
				result = (result * 397) ^ z.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex3f.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex3f.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0:F4}, {1:F4}, {2:F4}|", x, y, z));
		}

		#endregion
	}

	/// <summary>
	/// Vertex value type (double coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Double, 3)]
	[DebuggerDisplay("Vertex3d: X={x} Y={y} Z={z}")]
	public struct Vertex3d : IVertex3, IEquatable<IVertex3>
	{
		#region Constructors

		/// <summary>
		/// Vertex3d constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="double"/> that specify the value of every component.
		/// </param>
		public Vertex3d(double v) : this(v, v, v) { }

		/// <summary>
		/// Vertex3d constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="double[]"/> that specify the value of every component.
		/// </param>
		public Vertex3d(double[] v) : this(v[0], v[1], v[2]) { }

		/// <summary>
		/// Vertex3d constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="double"/> that specify the X coordinate.
		/// </param>
		/// <param name="y">
		/// A <see cref="double"/> that specify the Y coordinate.
		/// </param>
		/// <param name="z">
		/// A <see cref="double"/> that specify the Z coordinate.
		/// </param>
		public Vertex3d(double x, double y, double z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		/// <summary>
		/// Vertex3d constructor.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Vertex3d"/> that specify the vertex to be copied.
		/// </param>
		public Vertex3d(Vertex3d other) : this(other.x, other.y, other.z) { }

		#endregion

		#region Structure

		/// <summary>
		/// X coordinate for tridimensional vertex.
		/// </summary>
		public double x;

		/// <summary>
		/// Y coordinate for tridimensional vertex.
		/// </summary>
		public double y;

		/// <summary>
		/// Z coordinate for tridimensional vertex.
		/// </summary>
		public double z;

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Negate operator.
		/// </summary>
		/// <param name="v">
		/// The Vertex3d to negate.
		/// </param>
		/// <returns>
		/// It returns the negate of <paramref name="v"/>.
		/// </returns>
		public static Vertex3d operator -(Vertex3d v)
		{
			return (new Vertex3d((double)(-v.x), (double)(-v.y), (double)(-v.z)));
		}

		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3d"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3d"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> that equals to the addition of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex3d operator +(Vertex3d v1, Vertex3d v2)
		{
			Vertex3d v;

			v.x = (double)(v1.x + v2.x);
			v.y = (double)(v1.y + v2.y);
			v.z = (double)(v1.z + v2.z);

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3d"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3d"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> that equals to the subtraction of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex3d operator -(Vertex3d v1, Vertex3d v2)
		{
			Vertex3d v;

			v.x = (double)(v1.x - v2.x);
			v.y = (double)(v1.y - v2.y);
			v.z = (double)(v1.z - v2.z);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3d"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3d operator *(Vertex3d v1, float scalar)
		{
			Vertex3d v;

			v.x = (double)(v1.x * scalar);
			v.y = (double)(v1.y * scalar);
			v.z = (double)(v1.z * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3d"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3d operator *(Vertex3d v1, double scalar)
		{
			Vertex3d v;

			v.x = (double)(v1.x * scalar);
			v.y = (double)(v1.y * scalar);
			v.z = (double)(v1.z * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3d"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3d operator /(Vertex3d v1, float scalar)
		{
			Vertex3d v;

			v.x = (double)(v1.x / scalar);
			v.y = (double)(v1.y / scalar);
			v.z = (double)(v1.z / scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3d"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3d operator /(Vertex3d v1, double scalar)
		{
			Vertex3d v;

			v.x = (double)(v1.x / scalar);
			v.y = (double)(v1.y / scalar);
			v.z = (double)(v1.z / scalar);

			return (v);
		}

		/// <summary>
		/// Dot product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3d"/> representing the left dot product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3d"/> representing the right dot product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> representing the dot product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static float operator *(Vertex3d v1, Vertex3d v2)
		{
			return (float)(v1.x * v2.x + v1.y * v2.y + v1.z * v2.z);
		}

		/// <summary>
		/// Cross product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3d"/> representing the left cross product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3d"/> representing the right cross product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> representing the cross product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static Vertex3f operator ^(Vertex3d v1, Vertex3d v2)
		{
			Vertex3f v;

			v.x = (float)(v1.y * v2.z - v1.z * v2.y);
			v.y = (float)(v1.z * v2.x - v1.x * v2.z);
			v.z = (float)(v1.x * v2.y - v1.y * v2.x);

			return (v);
		}

		/// <summary>
		/// Vertex and matrix multiplication.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex3d"/> representing the vertex to be transformed.
		/// </param>
		/// <param name="m">
		/// A <see cref="Matrix4x4"/> representing the transformation matrix.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Vertex3f"/> which represents the transformed vertex.
		/// </returns>
		public static Vertex3f operator *(Vertex3d v, Matrix4x4 m)
		{
			Vertex3f r;

			r.x = (float)((v.x * m[0, 0]) + (v.y * m[0, 1]) + (v.z * m[0, 2]) + m[0, 3]);
			r.y = (float)((v.x * m[1, 1]) + (v.y * m[1, 1]) + (v.z * m[1, 2]) + m[1, 3]);
			r.z = (float)((v.x * m[2, 2]) + (v.y * m[2, 1]) + (v.z * m[2, 2]) + m[2, 3]);

			return (r);
		}


		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(Vertex3d v1, Vertex3d v2)
		{
			return (v1.Equals(v2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(Vertex3d v1, Vertex3d v2)
		{
			return (!v1.Equals(v2));
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to double[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3d"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="double[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator double[](Vertex3d a)
		{
			double[] v = new double[3];

			v[0] = a.x;
			v[1] = a.y;
			v[2] = a.z;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex2f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3d"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> initialized with the vector components, ignoring the Z component.
		/// </returns>
		public static explicit operator Vertex2f(Vertex3d v)
		{
			return (new Vertex2f(v.X, v.Y));
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3d"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex3f(Vertex3d v)
		{
			return (new Vertex3f(v.X, v.Y, v.Z));
		}

		/// <summary>
		/// Cast to Vertex4f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3d"/> to be casted.
		/// </param>
		/// <returns>
		/// A normalized <see cref="Vertex4f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex4f(Vertex3d v)
		{
			return (new Vertex4f(v.X, v.Y, v.Z, 1.0f));
		}

		/// <summary>
		/// Cast to Vertex4d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3d"/> to be casted.
		/// </param>
		/// <returns>
		/// A normalized <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4d(Vertex3d v)
		{
			return (new Vertex4d(v.X, v.Y, v.Z, 1.0f));
		}

		#endregion

		#region Vertex Methods

		/// <summary>
		/// Compute tridimensional vertex module.
		/// </summary>
		/// <returns>
		/// It returns the vertex vector module.
		/// </returns>
		public float Module()
		{
			float x2 = (float)(x * x);
			float y2 = (float)(y * y);
			float z2 = (float)(z * z);

			return ((float)Math.Sqrt(x2 + y2 + z2));
		}

		/// <summary>
		/// Normalize vertex coordinates.
		/// </summary>
		public void Normalize()
		{
			float length = Module();

			if (Math.Abs(length) < Single.Epsilon)
				throw new DivideByZeroException("zero length normalization");

			this /= length;
		}

		/// <summary>
		/// This vertex, but normalized.
		/// </summary>
		public Vertex3d Normalized
		{
			get
			{
				Vertex3d normalized = this;

				normalized.Normalize();

				return (normalized);
			}
		}

		#endregion

		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex3d Zero = new Vertex3d(0.0);

		/// <summary>
		/// Unit vertex along all axes.
		/// </summary>
		public static readonly Vertex3d One = new Vertex3d(1.0);

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly Vertex3d UnitX = new Vertex3d(1.0, 0.0, 0.0);

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly Vertex3d UnitY = new Vertex3d(0.0, 1.0, 0.0);

		/// <summary>
		/// Unit vertex along Z axis.
		/// </summary>
		public static readonly Vertex3d UnitZ = new Vertex3d(0.0, 0.0, 1.0);

		#endregion

		#region IVertex3 Implementation

		/// <summary>
		/// Vertex coordinate X, unclamped range.
		/// </summary>
		public float X
		{
			get { return ((float)x); }
			set { x = (double)value; }
		}

		/// <summary>
		/// Vertex coordinate Y, unclamped range.
		/// </summary>
		public float Y
		{
			get { return ((float)y); }
			set { y = (double)value; }
		}

		/// <summary>
		/// Vertex coordinate Z, unclamped range.
		/// </summary>
		public float Z
		{
			get { return ((float)z); }
			set { z = (double)value; }
		}

		#endregion

		#region IVertex Implementation

		/// <summary>
		/// Vertex components indexer.
		/// </summary>
		/// <param name="idx">
		/// A <see cref="UInt32"/> that specify the component index using for accessing to this IVertex component.
		/// </param>
		/// <remarks>
		/// <para>
		/// This indexer returns a single-precision floating-point representation of the vertex component value.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception thrown if <paramref name="idx"/> exceeds the maximum allowed component index.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the set value is outside the representable range of the underlying type.
		/// </exception>s
		public float this[uint idx]
		{
			get
			{
				switch (idx) {
					case 0: return (X);
					case 1: return (Y);
					case 2: return (Z);
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0: X = value; break;
					case 1: Y = value; break;
					case 2: Z = value; break;
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
		}

		#endregion

		#region IEquatable<IVertex3> Implementation

		/// <summary>
		/// Indicates whether the this IVertex3 is equal to another IVertex3.
		/// </summary>
		/// <param name="other">
		/// An IVertex3 to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IVertex3 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(IVertex3 other)
		{
			const float Epsilon = 1e-6f;

			if (ReferenceEquals(null, other))
				return false;

			if (Math.Abs(X - other.X) >= Epsilon)
				return (false);
			if (Math.Abs(Y - other.Y) >= Epsilon)
				return (false);
			if (Math.Abs(Z - other.Z) >= Epsilon)
				return (false);

			return (true);
		}

		/// <summary>
		/// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
		/// </summary>
		/// <param name="obj">
		/// The <see cref="T:System.Object"/> to compare with the current <see cref="T:System.Object"/>.
		/// </param>
		/// <returns>
		/// It returns true if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.
		/// </returns>
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj))
				return (false);
			if (obj.GetType().GetInterface("IVertex3") == null)
				return (false);

			return (Equals((IVertex3)obj));
		}

		/// <summary>
		/// Serves as a hash function for a particular type. <see cref="M:System.Object.GetHashCode"/> is suitable for
		/// use in hashing algorithms and data structures like a hash table.
		/// </summary>
		/// <returns>
		/// A hash code for the current <see cref="T:System.Object"/>.
		/// </returns>
		public override int GetHashCode()
		{
			unchecked {
				int result = x.GetHashCode();
				result = (result * 397) ^ y.GetHashCode();
				result = (result * 397) ^ z.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex3d.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex3d.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0:F4}, {1:F4}, {2:F4}|", x, y, z));
		}

		#endregion
	}

	/// <summary>
	/// Vertex value type (HalfFloat coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Half, 3)]
	[DebuggerDisplay("Vertex3hf: X={x} Y={y} Z={z}")]
	public struct Vertex3hf : IVertex3, IEquatable<IVertex3>
	{
		#region Constructors

		/// <summary>
		/// Vertex3hf constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="HalfFloat"/> that specify the value of every component.
		/// </param>
		public Vertex3hf(HalfFloat v) : this(v, v, v) { }

		/// <summary>
		/// Vertex3hf constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="HalfFloat[]"/> that specify the value of every component.
		/// </param>
		public Vertex3hf(HalfFloat[] v) : this(v[0], v[1], v[2]) { }

		/// <summary>
		/// Vertex3hf constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="HalfFloat"/> that specify the X coordinate.
		/// </param>
		/// <param name="y">
		/// A <see cref="HalfFloat"/> that specify the Y coordinate.
		/// </param>
		/// <param name="z">
		/// A <see cref="HalfFloat"/> that specify the Z coordinate.
		/// </param>
		public Vertex3hf(HalfFloat x, HalfFloat y, HalfFloat z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		/// <summary>
		/// Vertex3hf constructor.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Vertex3hf"/> that specify the vertex to be copied.
		/// </param>
		public Vertex3hf(Vertex3hf other) : this(other.x, other.y, other.z) { }

		#endregion

		#region Structure

		/// <summary>
		/// X coordinate for tridimensional vertex.
		/// </summary>
		public HalfFloat x;

		/// <summary>
		/// Y coordinate for tridimensional vertex.
		/// </summary>
		public HalfFloat y;

		/// <summary>
		/// Z coordinate for tridimensional vertex.
		/// </summary>
		public HalfFloat z;

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Negate operator.
		/// </summary>
		/// <param name="v">
		/// The Vertex3hf to negate.
		/// </param>
		/// <returns>
		/// It returns the negate of <paramref name="v"/>.
		/// </returns>
		public static Vertex3hf operator -(Vertex3hf v)
		{
			return (new Vertex3hf((HalfFloat)(-v.x), (HalfFloat)(-v.y), (HalfFloat)(-v.z)));
		}

		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3hf"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3hf"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3hf"/> that equals to the addition of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex3hf operator +(Vertex3hf v1, Vertex3hf v2)
		{
			Vertex3hf v;

			v.x = (HalfFloat)(v1.x + v2.x);
			v.y = (HalfFloat)(v1.y + v2.y);
			v.z = (HalfFloat)(v1.z + v2.z);

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3hf"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3hf"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3hf"/> that equals to the subtraction of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex3hf operator -(Vertex3hf v1, Vertex3hf v2)
		{
			Vertex3hf v;

			v.x = (HalfFloat)(v1.x - v2.x);
			v.y = (HalfFloat)(v1.y - v2.y);
			v.z = (HalfFloat)(v1.z - v2.z);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3hf"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3hf"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3hf operator *(Vertex3hf v1, float scalar)
		{
			Vertex3hf v;

			v.x = (HalfFloat)(v1.x * scalar);
			v.y = (HalfFloat)(v1.y * scalar);
			v.z = (HalfFloat)(v1.z * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3hf"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3hf"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3hf operator *(Vertex3hf v1, double scalar)
		{
			Vertex3hf v;

			v.x = (HalfFloat)(v1.x * scalar);
			v.y = (HalfFloat)(v1.y * scalar);
			v.z = (HalfFloat)(v1.z * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3hf"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3hf"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3hf operator /(Vertex3hf v1, float scalar)
		{
			Vertex3hf v;

			v.x = (HalfFloat)(v1.x / scalar);
			v.y = (HalfFloat)(v1.y / scalar);
			v.z = (HalfFloat)(v1.z / scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3hf"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3hf"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex3hf operator /(Vertex3hf v1, double scalar)
		{
			Vertex3hf v;

			v.x = (HalfFloat)(v1.x / scalar);
			v.y = (HalfFloat)(v1.y / scalar);
			v.z = (HalfFloat)(v1.z / scalar);

			return (v);
		}

		/// <summary>
		/// Dot product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3hf"/> representing the left dot product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3hf"/> representing the right dot product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3hf"/> representing the dot product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static float operator *(Vertex3hf v1, Vertex3hf v2)
		{
			return (float)(v1.x * v2.x + v1.y * v2.y + v1.z * v2.z);
		}

		/// <summary>
		/// Cross product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex3hf"/> representing the left cross product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex3hf"/> representing the right cross product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3hf"/> representing the cross product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static Vertex3f operator ^(Vertex3hf v1, Vertex3hf v2)
		{
			Vertex3f v;

			v.x = (float)(v1.y * v2.z - v1.z * v2.y);
			v.y = (float)(v1.z * v2.x - v1.x * v2.z);
			v.z = (float)(v1.x * v2.y - v1.y * v2.x);

			return (v);
		}

		/// <summary>
		/// Vertex and matrix multiplication.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex3hf"/> representing the vertex to be transformed.
		/// </param>
		/// <param name="m">
		/// A <see cref="Matrix4x4"/> representing the transformation matrix.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Vertex3f"/> which represents the transformed vertex.
		/// </returns>
		public static Vertex3f operator *(Vertex3hf v, Matrix4x4 m)
		{
			Vertex3f r;

			r.x = (float)((v.x * m[0, 0]) + (v.y * m[0, 1]) + (v.z * m[0, 2]) + m[0, 3]);
			r.y = (float)((v.x * m[1, 1]) + (v.y * m[1, 1]) + (v.z * m[1, 2]) + m[1, 3]);
			r.z = (float)((v.x * m[2, 2]) + (v.y * m[2, 1]) + (v.z * m[2, 2]) + m[2, 3]);

			return (r);
		}


		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(Vertex3hf v1, Vertex3hf v2)
		{
			return (v1.Equals(v2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(Vertex3hf v1, Vertex3hf v2)
		{
			return (!v1.Equals(v2));
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to HalfFloat[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3hf"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="HalfFloat[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator HalfFloat[](Vertex3hf a)
		{
			HalfFloat[] v = new HalfFloat[3];

			v[0] = a.x;
			v[1] = a.y;
			v[2] = a.z;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex2f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3hf"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> initialized with the vector components, ignoring the Z component.
		/// </returns>
		public static explicit operator Vertex2f(Vertex3hf v)
		{
			return (new Vertex2f(v.X, v.Y));
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3hf"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex3f(Vertex3hf v)
		{
			return (new Vertex3f(v.X, v.Y, v.Z));
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3hf"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex3d(Vertex3hf v)
		{
			return (new Vertex3d(v.X, v.Y, v.Z));
		}

		/// <summary>
		/// Cast to Vertex4f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3hf"/> to be casted.
		/// </param>
		/// <returns>
		/// A normalized <see cref="Vertex4f"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4f(Vertex3hf v)
		{
			return (new Vertex4f(v.X, v.Y, v.Z, 1.0f));
		}

		/// <summary>
		/// Cast to Vertex4d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3hf"/> to be casted.
		/// </param>
		/// <returns>
		/// A normalized <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4d(Vertex3hf v)
		{
			return (new Vertex4d(v.X, v.Y, v.Z, 1.0f));
		}

		#endregion

		#region Vertex Methods

		/// <summary>
		/// Compute tridimensional vertex module.
		/// </summary>
		/// <returns>
		/// It returns the vertex vector module.
		/// </returns>
		public float Module()
		{
			float x2 = (float)(x * x);
			float y2 = (float)(y * y);
			float z2 = (float)(z * z);

			return ((float)Math.Sqrt(x2 + y2 + z2));
		}

		/// <summary>
		/// Normalize vertex coordinates.
		/// </summary>
		public void Normalize()
		{
			float length = Module();

			if (Math.Abs(length) < Single.Epsilon)
				throw new DivideByZeroException("zero length normalization");

			this /= length;
		}

		/// <summary>
		/// This vertex, but normalized.
		/// </summary>
		public Vertex3hf Normalized
		{
			get
			{
				Vertex3hf normalized = this;

				normalized.Normalize();

				return (normalized);
			}
		}

		#endregion
		#region IVertex3 Implementation

		/// <summary>
		/// Vertex coordinate X, unclamped range.
		/// </summary>
		public float X
		{
			get { return ((float)x); }
			set { x = (HalfFloat)value; }
		}

		/// <summary>
		/// Vertex coordinate Y, unclamped range.
		/// </summary>
		public float Y
		{
			get { return ((float)y); }
			set { y = (HalfFloat)value; }
		}

		/// <summary>
		/// Vertex coordinate Z, unclamped range.
		/// </summary>
		public float Z
		{
			get { return ((float)z); }
			set { z = (HalfFloat)value; }
		}

		#endregion

		#region IVertex Implementation

		/// <summary>
		/// Vertex components indexer.
		/// </summary>
		/// <param name="idx">
		/// A <see cref="UInt32"/> that specify the component index using for accessing to this IVertex component.
		/// </param>
		/// <remarks>
		/// <para>
		/// This indexer returns a single-precision floating-point representation of the vertex component value.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception thrown if <paramref name="idx"/> exceeds the maximum allowed component index.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the set value is outside the representable range of the underlying type.
		/// </exception>s
		public float this[uint idx]
		{
			get
			{
				switch (idx) {
					case 0: return (X);
					case 1: return (Y);
					case 2: return (Z);
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0: X = value; break;
					case 1: Y = value; break;
					case 2: Z = value; break;
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
		}

		#endregion

		#region IEquatable<IVertex3> Implementation

		/// <summary>
		/// Indicates whether the this IVertex3 is equal to another IVertex3.
		/// </summary>
		/// <param name="other">
		/// An IVertex3 to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IVertex3 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(IVertex3 other)
		{
			const float Epsilon = 1e-6f;

			if (ReferenceEquals(null, other))
				return false;

			if (Math.Abs(X - other.X) >= Epsilon)
				return (false);
			if (Math.Abs(Y - other.Y) >= Epsilon)
				return (false);
			if (Math.Abs(Z - other.Z) >= Epsilon)
				return (false);

			return (true);
		}

		/// <summary>
		/// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
		/// </summary>
		/// <param name="obj">
		/// The <see cref="T:System.Object"/> to compare with the current <see cref="T:System.Object"/>.
		/// </param>
		/// <returns>
		/// It returns true if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.
		/// </returns>
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj))
				return (false);
			if (obj.GetType().GetInterface("IVertex3") == null)
				return (false);

			return (Equals((IVertex3)obj));
		}

		/// <summary>
		/// Serves as a hash function for a particular type. <see cref="M:System.Object.GetHashCode"/> is suitable for
		/// use in hashing algorithms and data structures like a hash table.
		/// </summary>
		/// <returns>
		/// A hash code for the current <see cref="T:System.Object"/>.
		/// </returns>
		public override int GetHashCode()
		{
			unchecked {
				int result = x.GetHashCode();
				result = (result * 397) ^ y.GetHashCode();
				result = (result * 397) ^ z.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex3hf.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex3hf.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0:F4}, {1:F4}, {2:F4}|", x, y, z));
		}

		#endregion
	}

}