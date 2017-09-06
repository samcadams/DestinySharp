
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny
{
    public class DestinyTalentNode
    {
		public int nodeIndex;
		public ulong nodeHash;
		public bool isActivated;
		public int stepIndex;
		public Destiny.Definitions.DestinyMaterialRequirement[] materialsToUpgrade;
		public int activationGridLevel;
		public decimal progressPercent;
		public bool hidden;
	}
}