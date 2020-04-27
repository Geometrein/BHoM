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

using System.Collections.Generic;
using BH.oM.Environment.MaterialFragments;
using BH.oM.Base;

namespace BH.oM.LifeCycleAssessment
{
    public interface IEnvironmentalProductDeclarationData : IBHoMObject, IEnvironmentMaterial, IFragment
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/
        QuantityType QuantityType { get; set; }
        //List<LifeCycleAssessmentPhases> LifeCycleAssessmentPhases { get; } = new List<LifeCycleAssessmentPhases>(); <-- WIP Collect all LCA Phases from data
        string Id { get; set; }
        //double Density { get; set; } <-- Removed as property is now inherited from IEnvironmentMaterial
        //string Description { get; set; } <-- Removed as property is now inherited from IEnvironmentMaterial
        //string Scope { get; set; } <-- Replaced by LifeCycleAssessmentPhases enum
        double GlobalWarmingPotential { get; set; }
        double BiogenicEmbodiedCarbon { get; set; }
        double OzoneDepletionPotential { get; set; }
        double PhotochemicalOzoneCreationPotential { get; set; }
        double AcidificationPotential { get; set; }
        double EutrophicationPotential { get; set; }
        double DepletionOfAbioticResourcesFossilFuels { get; set; }
        double GlobalWarmingPotentialEndOfLife { get; set; }
        double OzoneDepletionPotentialEndOfLife { get; set; }
        double PhotochemicalOzoneCreationPotentialEndOfLife { get; set; }
        double AcidificationPotentialEndOfLife { get; set; }
        double EutrophicationPotentialEndOfLife { get; set; }
        double DepletionOfAbioticResourcesFossilFuelsEndOfLife { get; set; }
        string EndOfLifeTreatment { get; set; }
        /***************************************************/
    }
}