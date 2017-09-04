
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Definitions.Progression
{
    public class DestinyProgressionLevelRequirementDefinition
    {
        public Interpolation.InterpolationPointFloat[] requirementCurve;
        public int progressionHash;
        public int hash;
        public int index;
        public bool redacted;
    }
}