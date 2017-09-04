
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Definitions
{
    public class DestinyNodeStepDefinition
    {
        public int stepIndex;
        public int nodeStepHash;
        public string interactionDescription;
        public int damageTypeHash;
        public bool canActivateNextStep;
        public int nextStepIndex;
        public bool isNextStepRandom;
        public UInt32[] perkHashes;
        public int startProgressionBarAtProgress;
        public UInt32[] statHashes;
        public bool affectsQuality;
        public bool affectsLevel;
        public Destiny.Definitions.DestinyNodeSocketReplaceResponse[] socketReplacements;
    }
}