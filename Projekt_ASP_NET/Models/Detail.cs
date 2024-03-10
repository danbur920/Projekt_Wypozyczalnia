namespace Projekt_ASP_NET.Models
{
    public class Detail
    {
        public int Id { get; set; }
        public float? Length { get; set; }
        public float? Width { get; set; }
        public float? Weight { get; set; }
        public string? Color { get; set; }
        public float? Horsepower { get; set; }
        public bool? IsCombustionVehicle { get; set; }
        public bool? IsElectricVehicle { get; set; }
        public int? VehicleId { get; set; }
        public virtual Vehicle? Vehicle { get; set; }
    }
}
