﻿/*
 * Copyright (c) 2014-2015 Håkan Edling
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 * 
 * http://github.com/piranhacms/piranha.vnext
 * 
 */

using System;

namespace Piranha.Extend.Blocks
{
	/// <summary>
	/// Unformatted string content.
	/// </summary>
	[Block(Name="Text")]
	public class Text : IBlock
	{
		/// <summary>
		/// Gets/sets the body.
		/// </summary>
		public string Body { get; set; }
	}
}