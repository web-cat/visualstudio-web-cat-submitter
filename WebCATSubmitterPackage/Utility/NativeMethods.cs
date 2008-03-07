//
//	This file is part of the Web-CAT Electronic Submission Package for Visual
//	Studio.NET.
//
//	Web-CAT is free software; you can redistribute it and/or modify
//	it under the terms of the GNU General Public License as published by
//	the Free Software Foundation; either version 2 of the License, or
//	(at your option) any later version.
//
//	Web-CAT is distributed in the hope that it will be useful,
//	but WITHOUT ANY WARRANTY; without even the implied warranty of
//	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//	GNU General Public License for more details.
//
//	You should have received a copy of the GNU General Public License
//	along with Web-CAT; if not, write to the Free Software
//	Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
//

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace WebCAT.Submitter.VisualStudio.Utility
{
	/// <summary>
	/// Contains any native methods that are imported through interop services.
	/// </summary>
	internal static class NativeMethods
	{
		// --------------------------------------------------------------------
		// Since the Windows Forms ImageList class does not permit us to
		// create an imagelist from a Win32 HIMAGELIST handle, we import this
		// method instead to access an icon from the handle directly.
		[DllImport("comctl32.dll")]
		public static extern IntPtr ImageList_GetIcon(IntPtr hImageList,
			int i, uint flags);

		// --------------------------------------------------------------------
		// Destroy the icon that was returned by ImageList_GetIcon.
		[DllImport("user32.dll")]
		public static extern int DestroyIcon(IntPtr hIcon);
	}
}
