namespace DestinySharp.Core.Entities
{
    public class InventoryBucket : ManifestDefinition
    {
        public ulong BucketHash { get; set; }
        public string BucketName { get; set; }
        public string BucketDescription { get; set; }
        public BucketScope Scope { get; set; }
        public BucketCategory Category { get; set; }
        public int bucketOrder { get; set; }
        public string BucketIdentifier { get; set; }
        public int itemCount { get; set; }
        public int location { get; set; }
        public bool HasTranferDestination { get; set; }
        public bool Enabled { get; set; }
        public bool Fifo { get; set; }
    }
}
