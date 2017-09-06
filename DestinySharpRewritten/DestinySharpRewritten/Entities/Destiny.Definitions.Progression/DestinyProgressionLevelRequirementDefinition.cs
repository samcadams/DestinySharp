
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Definitions.Progression
{
    public class DestinyProgressionLevelRequirementDefinition
    {
		public Interpolation.InterpolationPointFloat[] requirementCurve;
		public ulong progressionHash;
		public ulong hash;
		public int index;
		public bool redacted;
	}
}