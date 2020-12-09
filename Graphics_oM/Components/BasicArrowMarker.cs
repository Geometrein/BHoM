﻿using BH.oM.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH.oM.Graphics.Components
{
    [Description("Basic arrow head marker.")]
    public class BasicArrowMarker : BHoMObject, IMarker
    {
        public virtual double HeadLength { get; set; } = 1;

        public virtual double BaseWidth { get; set; } = 1;

        public virtual bool Closed { get; set; } = false;
    }
}