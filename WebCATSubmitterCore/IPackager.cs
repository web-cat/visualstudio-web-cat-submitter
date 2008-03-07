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
	public interface IPackager
	{
		//  -------------------------------------------------------------------
		/// <summary>
		/// Starts a new package that will be written to the specified stream.
		/// </summary>
		/// <param name="stream">
		/// The stream to which the package will be written.
		/// </param>
		/// <param name="parameters">
		/// A dictionary of parameters that are specified in the target
		/// definition.
		/// </param>
		void StartPackage(Stream stream,
			Dictionary<string, string> parameters);

		//  -------------------------------------------------------------------
		/// <summary>
		/// Adds a submittable item to the package that was started by a call
		/// to StartPackage.
		/// </summary>
		/// <param name="item"></param>
		void AddSubmittableItem(ISubmittableItem item);

		//  -------------------------------------------------------------------
		/// <summary>
		/// Finalizes the package that was started by a call to StartPackage.
		/// This method should flush the stream but NOT close it.
		/// </summary>
		void EndPackage();
	}
}
