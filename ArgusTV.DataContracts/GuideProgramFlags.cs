﻿/*
 *	Copyright (C) 2007-2014 ARGUS TV
 *	http://www.argus-tv.com
 *
 *  This Program is free software; you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation; either version 2, or (at your option)
 *  any later version.
 *
 *  This Program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with GNU Make; see the file COPYING.  If not, write to
 *  the Free Software Foundation, 675 Mass Ave, Cambridge, MA 02139, USA.
 *  http://www.gnu.org/copyleft/gpl.html
 *
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArgusTV.DataContracts
{
    /// <summary>
    /// Flags defining the program's broadcast (aspect ration, SD or HD,...).
    /// </summary>
    [Flags]
    public enum GuideProgramFlags
    {
        /// <summary>
        /// Standard or 4:3 aspect ratio.
        /// </summary>
        StandardAspectRatio = 0x1,
        /// <summary>
        /// Widescreen or 16:9 aspect ratio.
        /// </summary>
        WidescreenAspectRatio = 0x2,
        /// <summary>
        /// HDTV broadcast.
        /// </summary>
        HighDefinition = 0x4,
    }
}
