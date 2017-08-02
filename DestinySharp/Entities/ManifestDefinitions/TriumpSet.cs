using System;
using System.Collections.Generic;

namespace DestinySharp.Core.Entities
{
    public class TriumpSet : ManifestDefinition
    {
        public ulong TriumphSetHash { get; set; }
        public string Identifier { get; set; }
        public int Order { get; set; }
        public string Title { get; set; }
        public string IconPath { get; set; }
        public string IncompleteSubtitle { get; set; }
        public string IncompleteDetails { get; set; }
        public string CompletedSubtitle { get; set; }
        public string CompletedDetails { get; set; }
        public string LockedSubtitle { get; set; }
        public string LockedDetails { get; set; }
        public DateTime LockdownDate { get; set; }
        public List<TriumphSetTriump> Triumphs { get; set; }
        public bool isRecordBook { get; set; }
        public ulong LockdownUnlockHash { get; set; }
    }

    public class TriumphSetTriump
    {
        public string Identifier { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string IconPath { get; set; }
        public bool hasProgress { get; set; }
        public int MinimumProgress { get; set; }
        public int MaximumProgress { get; set; }
    }
}