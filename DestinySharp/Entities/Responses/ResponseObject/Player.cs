namespace DestinySharp.Core.Entities.Responses.ResponseObject
{
    public class Player
    {
        public string DisplayName { get; set; }
        public MembershipType MembershipType { get; set; }
        public string IconPath { get; set; }
        public string MembershipId { get; set; }

        public override string ToString()
        {
            return $"{DisplayName} - {MembershipId}";
        }
    }
}