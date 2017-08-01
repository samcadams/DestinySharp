using System.Collections.Generic;

namespace DestinySharp.Core.Entities
{
    public class DirectorBook : ManifestDefinition
    {
        public ulong BookHash { get; set; }
        public string BookName { get; set; }
        public string BookDescription { get; set; }
        public string BookNumber { get; set; }
        public List<DirectorBookNode> Nodes { get; set; }
        public List<DirectorBookConnection> Connections { get; set; }
        public bool Visible { get; set; }
        public bool IsOverview { get; set; }
        public DirectorBookDefaultExpression IsDefaultExpression { get; set; }
        public DirectorBookVisibleExpression IsVisibleExpression { get; set; }
        public ulong DestinationHash { get; set; }
    }

    public class DirectorBookStep
    {
        public int StepOperator { get; set; }
        public ulong FlagHash { get; set; }
        public ulong ValueHash { get; set; }
        public int Value { get; set; }
    }

    public class DirectorBookDefaultExpression
    {
        public List<DirectorBookStep> Steps { get; set; }
    }

    public class DirectorBookVisibleExpression
    {
        public List<DirectorBookStep> Steps { get; set; }
    }

    public class DirectorBookConnection
    {
        public int SourceNodeIndex { get; set; }
        public int DestinationNodeIndex { get; set; }
    }

    public class DirectorBookNode
    {
        public ulong NodeDefinitionHash { get; set; }
        public ulong StyleHash { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int PositionZ { get; set; }
        public List<ulong> ActivityBundleHashes { get; set; }
        public List<DirectorBookState> States { get; set; }
        public int UIModifier { get; set; }
    }

    public class DirectorBookState
    {
        public int State { get; set; }
    }
}
