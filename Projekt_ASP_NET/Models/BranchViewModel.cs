namespace Projekt_ASP_NET.Models
{
    public class BranchViewModel
    {
        public int Id { get; set; }
        public string City { get; set; }
        public int? NumberOfVehicles { get; set; }
        public virtual List<VehicleItemViewModel>? VehicleItems { get; set; }
    }
}
