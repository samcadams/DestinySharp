
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Definitions.Items
{
    public class DestinyItemPlugDefinition
    {
        public Destiny.Definitions.Items.DestinyPlugRuleDefinition[] insertionRules;
        public string plugCategoryIdentifier;
        public int plugCategoryHash;
        public bool onActionRecreateSelf;
        public int insertionMaterialRequirementHash;
        public int previewItemOverrideHash;
        public int enabledMaterialRequirementHash;
        public Destiny.Definitions.Items.DestinyPlugRuleDefinition[] enabledRules;
    }
}