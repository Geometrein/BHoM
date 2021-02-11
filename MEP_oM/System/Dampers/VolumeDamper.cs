/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2021, the respective contributors. All rights reserved.
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

using BH.oM.Base;
using BH.oM.Dimensional;
using BH.oM.Quantities.Attributes;
using System.ComponentModel;
using BH.oM.MEP.Fragments;
using BH.oM.MEP.System.SectionProperties;
using System.Collections.Generic;

namespace BH.oM.MEP.System.Dampers
{
    [Description("A type of damper used to control the flow of air in a mechanical system.")]
    public class VolumeDamper : BHoMObject, ICoincident
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        [Description("The point in space for the location of the object.")]
        public virtual Node Location { get; set; } = new Node();

        [Description("A DimensionalFragment containing spatial properties of the element.")]
        public virtual DimensionalFragment ElementSize { get; set; } = new DimensionalFragment();

        [Description("The element section property defines the shape (round, rectangular, ovular) and its associated properties (height, width, radius, material, thickness/gauge).")]
        public virtual List<SectionProfile> SectionProfile { get; set; } = null;

        [Angle]
        [Description("Controls the local plan orientation of the object.")]
        public virtual double OrientationAngle { get; set; } = 0;

        [Description("A data fragment that contains information regarding the consumption properties of the object.")]
        public virtual List<FlowFragment> Flow { get; set; }

        /***************************************************/
    }
}

