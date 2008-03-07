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

namespace WebCAT.Submitter.VisualStudio
{
	/// <summary>
	/// Constants that identify the commands defined in this package. These
	/// values must correspond to the values in CommandIds.h that are used
	/// when processing the CTC table.
	/// </summary>
    internal static class CommandIds
    {
		/// <summary>
		/// The command that submits the entire solution.
		/// </summary>
        public const uint SubmitSolution = 0x100;

		/// <summary>
		/// The command that submits the selected project(s).
		/// </summary>
		public const uint SubmitProject = 0x101;
    }
}