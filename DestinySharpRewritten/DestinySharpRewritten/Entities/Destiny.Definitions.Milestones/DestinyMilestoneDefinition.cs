
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Definitions.Milestones
{
    public class DestinyMilestoneDefinition
    {
public Destiny.Definitions.Common.DestinyDisplayPropertiesDefinition displayProperties;
		public string image;
		public bool recruitable;
		public string friendlyName;
		public bool showInExplorer;
		public bool hasPredictableDates;
		public Destiny.Definitions.Milestones.DestinyMilestoneVendorDefinition[] vendors;
		public bool isInGameMilestone;
		public ulong hash;
		public int index;
		public bool redacted;
	}
}