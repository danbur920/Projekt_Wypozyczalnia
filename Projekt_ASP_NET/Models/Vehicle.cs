﻿using System.ComponentModel.DataAnnotations;

namespace Projekt_ASP_NET.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Nazwa pojazdu jest wymagana.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Marka pojazdu jest wymagana.")]

        public string Brand { get; set; }
        public string? Image { get; set; }
        public bool? IsAvailable { get; set; }
        public float? PricePerHour { get; set; }
        public float? PricePerDay { get; set; }
        public float? PricePerMonth { get; set; } 
        public float? PurchasePrice { get; set; }
        public int? DetailId { get; set; }
        public int? BranchId { get; set; }
        public virtual Detail? Detail { get; set; }
        public virtual Branch? Branch { get; set; }
        public virtual List<Hire>? Hires { get; set; }
    }
}
