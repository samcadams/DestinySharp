
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Definitions
{
    public class DestinyStatDisplayDefinition
    {
		public ulong statHash;
		public int maximumValue;
		public bool displayAsNumeric;
		public Interpolation.InterpolationPoint[] displayInterpolation;
	}
}