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
using System.Text;

namespace WebCAT.Submitter
{
	/// <summary>
	/// Thrown when a submission is attempted that does not contain one or
	/// more files that are marked as required in the submission target.
	/// </summary>
	public class RequiredFilesMissingException : Exception
	{
		//  -------------------------------------------------------------------
		/// <summary>
		/// Creates a new instance of the RequiredFilesMissingException class.
		/// </summary>
		/// <param name="files">
		/// An array of the filenames (or file patterns) that could not be
		/// found in the submission.
		/// </param>
		public RequiredFilesMissingException(string[] files)
		{
			missingFiles = files;
		}

		//  -------------------------------------------------------------------
		/// <summary>
		/// Gets the filenames (or file patterns) that could not be found in
		/// the submission.
		/// </summary>
		public string[] MissingFiles
		{
			get
			{
				return missingFiles;
			}
		}

		
		// ==== Fields ========================================================

		// The filenames (or file patterns) that could not be found in the
		// submission.
		private string[] missingFiles;
	}
}
