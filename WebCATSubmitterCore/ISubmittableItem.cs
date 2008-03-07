//
//	This file is part of the Web-CAT Electronic Submission engine for the
//  .NET Framework.
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
using System.IO;

namespace WebCAT.Submitter
{
	//  =======================================================================
	/// <summary>
	/// Specifies the possible kinds of submittable items.
	/// </summary>
	public enum SubmittableItemKind
	{
		/// <summary>
		/// A submittable item that represents a folder to contain other items.
		/// </summary>
		Folder,

		/// <summary>
		/// A submittable item that represents a file.
		/// </summary>
		File
	}

	//  =======================================================================
	/// <summary>
	/// A submittable item is a member of a submittable collection and
	/// represents any single piece of that collection that can be submitted,
	/// such as a solution, project, source file, or folder.
	/// </summary>
	public interface ISubmittableItem
	{
		//  -------------------------------------------------------------------
		/// <summary>
		/// The filename of this submittable item, relative in terms of its
		/// location in the package that it will be stored in.
		/// </summary>
		string Filename
		{
			get;
		}

		//  -------------------------------------------------------------------
		/// <summary>
		/// The kind of item represented by this object. A submittable item
		/// can represent either a folder for containing other files or a file
		/// itself.
		/// </summary>
		SubmittableItemKind Kind
		{
			get;
		}

		//  -------------------------------------------------------------------
		/// <summary>
		/// An input stream from which to read the contents of this item, if
		/// Kind is equal to File.
		/// </summary>
		Stream GetStream();

		//  -------------------------------------------------------------------
		/// <summary>
		/// The children of this submittable item, if any.
		/// </summary>
		IEnumerable<ISubmittableItem> Children
		{
			get;
		}
	}
}
