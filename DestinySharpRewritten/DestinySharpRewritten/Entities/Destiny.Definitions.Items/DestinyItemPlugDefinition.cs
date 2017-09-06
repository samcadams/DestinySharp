
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Definitions.Items
{
    public class DestinyItemPlugDefinition
    {
		public Destiny.Definitions.Items.DestinyPlugRuleDefinition[] insertionRules;
		public string plugCategoryIdentifier;
		public ulong plugCategoryHash;
		public bool onActionRecreateSelf;
		public ulong insertionMaterialRequirementHash;
		public ulong previewItemOverrideHash;
		public ulong enabledMaterialRequirementHash;
		public Destiny.Definitions.Items.DestinyPlugRuleDefinition[] enabledRules;
	}
}