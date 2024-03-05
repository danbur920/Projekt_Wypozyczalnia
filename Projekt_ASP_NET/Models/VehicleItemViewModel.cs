namespace Projekt_ASP_NET.Models
{
    public class VehicleItemViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public string? Image { get; set; }
        public bool? IsAvailable { get; set; }
        public bool? IsReserved { get; set; }
        public float? PricePerHour { get; set; }
        public float? PricePerDay { get; set; }
        public float? PricePerWeek { get; set; }
        public float? PricePerMonth { get; set; }
        public float? PurchasePrice { get; set; }
        public int VehicleDetailId { get; set; }
        public int BranchId { get; set; }
        public virtual VehicleDetailViewModel VehicleDetail { get; set; }
        public virtual BranchViewModel Branch { get; set; }
    }
}
