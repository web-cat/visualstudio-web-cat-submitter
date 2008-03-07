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
	/// Thrown when a submission is attempted that uses a transport URI whose
	/// scheme protocol is not currently registered with the submission engine.
	/// </summary>
	public class ProtocolNotRegisteredException : Exception
	{
		//  -------------------------------------------------------------------
		/// <summary>
		/// Creates a new instance of the ProtocolNotRegisteredException class.
		/// </summary>
		/// <param name="scheme">
		/// The scheme that was requested but not registered.
		/// </param>
		public ProtocolNotRegisteredException(string scheme)
		{
			this.scheme = scheme;
		}

		//  -------------------------------------------------------------------
		/// <summary>
		/// Gets the scheme that was requested but not registered.
		/// </summary>
		public string Scheme
		{
			get
			{
				return scheme;
			}
		}

		
		// ==== Fields ========================================================

		// The scheme that was requested but not registered.
		private string scheme;
	}
}
