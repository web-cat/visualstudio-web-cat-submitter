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
using System.Windows.Forms;

namespace WebCAT.Submitter.VisualStudio.Utility
{
	/// <summary>
	/// This TreeNode subclass does not add any functionality, but exists as
	/// a distinct type that is added to unexpanded nodes in the submission
	/// wizard before they are first expanded. Once expanded, the placeholder
	/// is removed and replaced with the actual children of the node.
	/// </summary>
	class PlaceholderTreeNode : TreeNode
	{
	}
}
