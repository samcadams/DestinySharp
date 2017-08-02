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
        public string identifier { get; set; }
        public string title { get; set; }
        public string subtitle { get; set; }
        public string iconPath { get; set; }
        public bool hasProgress { get; set; }
        public int minimumProgress { get; set; }
        public int maximumProgress { get; set; }
    }
}