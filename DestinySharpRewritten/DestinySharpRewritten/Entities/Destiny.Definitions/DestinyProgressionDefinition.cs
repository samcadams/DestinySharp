
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Definitions
{
    public class DestinyProgressionDefinition
    {
public Destiny.Definitions.DestinyProgressionDisplayPropertiesDefinition displayProperties;
		public bool repeatLastStep;
		public string source;
		public Destiny.Definitions.DestinyProgressionStepDefinition[] steps;
		public bool visible;
		public ulong factionHash;
		public ulong hash;
		public int index;
		public bool redacted;
	}
}