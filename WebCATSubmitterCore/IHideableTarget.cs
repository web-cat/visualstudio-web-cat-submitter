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
	/// An interface implemented by submission target objects that can be
	/// hidden. Users can query for this interface by using asking
	/// "target is IHideableTarget" and then, if true, performing the cast
	/// and getting the value of the Hidden property.
	/// </summary>
	public interface IHideableTarget
	{
		//  -------------------------------------------------------------------
		/// <summary>
		/// Gets or sets a value indicating whether or not the target should be
		/// hidden.
		/// </summary>
		bool Hidden
		{
			get;
			set;
		}
	}
}
