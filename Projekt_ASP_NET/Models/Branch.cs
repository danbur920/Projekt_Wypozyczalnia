namespace Projekt_ASP_NET.Models
{
    public class Branch
    {
        public int Id { get; set; }
        public string? Locality { get; set; }
        public int? NumberOfVehicles { get; set; }
        public string? UserId { get; set; }
        public virtual List<Vehicle>? Vehicles { get; set; }
        public virtual User? User { get; set; }
    }
}
