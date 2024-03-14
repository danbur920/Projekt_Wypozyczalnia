namespace Projekt_ASP_NET.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Role { get; set; } // worker, admin

        public virtual List<Hire>? Hires { get; set; }
    }
}
