
// Copyright (C) 2015-2016 Luca Piccioni
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

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// Value of GL_COMPRESSED_SRGB_S3TC_DXT1_EXT symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_SRGB_S3TC_DXT1_NV")]
		[RequiredByFeature("GL_EXT_texture_sRGB")]
		[RequiredByFeature("GL_NV_sRGB_formats", Api = "gles2")]
		public const int COMPRESSED_SRGB_S3TC_DXT1_EXT = 0x8C4C;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_NV")]
		[RequiredByFeature("GL_EXT_texture_sRGB")]
		[RequiredByFeature("GL_NV_sRGB_formats", Api = "gles2")]
		public const int COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT = 0x8C4D;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_NV")]
		[RequiredByFeature("GL_EXT_texture_sRGB")]
		[RequiredByFeature("GL_NV_sRGB_formats", Api = "gles2")]
		public const int COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT = 0x8C4E;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_NV")]
		[RequiredByFeature("GL_EXT_texture_sRGB")]
		[RequiredByFeature("GL_NV_sRGB_formats", Api = "gles2")]
		public const int COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT = 0x8C4F;

	}

}
