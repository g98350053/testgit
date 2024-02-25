namespace testyungching.Bussinse.Models
{
    public class HouseDataModel
    {
        public required string HouseId { get; set; }
        public required string HouseName { get; set; }
        public required int HouseType { get; set; }
        public required decimal  HouseSize { get; set; }
        public required decimal HousePrice { get; set; }
        public required string HouseOwnerId { get; set; }
        public required string HouseOwnerName { get; set; }
        public required DateTime CreateDate { get; set; }
        public required string CreateUserId { get; set; }
        public   int? HouseStatus { get; set; }
        public   string HouseAddress { get; set; }
        public   string HousePhone { get; set; }

    }
}
