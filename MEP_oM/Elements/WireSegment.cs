﻿/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2020, the respective contributors. All rights reserved.
 *
 * Each contributor holds copyright over their respective contributions.
 * The project versioning (Git) records all such contribution source information.
 *                                           
 *                                                                              
 * The BHoM is free software: you can redistribute it and/or modify         
 * it under the terms of the GNU Lesser General Public License as published by  
 * the Free Software Foundation, either version 3.0 of the License, or          
 * (at your option) any later version.                                          
 *                                                                              
 * The BHoM is distributed in the hope that it will be useful,              
 * but WITHOUT ANY WARRANTY; without even the implied warranty of               
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the                 
 * GNU Lesser General Public License for more details.                          
 *                                                                            
 * You should have received a copy of the GNU Lesser General Public License     
 * along with this code. If not, see <https://www.gnu.org/licenses/lgpl-3.0.html>.      
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

using BH.oM.Base;
using BH.oM.Analytical.Elements;
using BH.oM.MEP.SectionProperties;
using BH.oM.Dimensional;


namespace BH.oM.MEP.Elements
{
    [Description("An object containing a collection of Wires to work within an MEP systems.")]
    public class WireSegment : BHoMObject, IFlow, ILink<Node>, IElement1D, IElementM
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        [Description("The point at which the Wire object begins.")]
        public virtual Node StartNode { get; set; } = null;

        [Description("The point at which the Wire object ends.")]
        public virtual Node EndNode { get; set; } = null;

        [Description("The amount of current being carried by the wire, the ampacity of the wire.")]
        public virtual double FlowRate { get; set; } = 0;

        [Description("Section property of the Wire, containing all material as well as profile geometry and dimensions, where applicable.")]
        public virtual WireSectionProperty SectionProperty { get; set; } = null;


        /***************************************************/
    }
}