namespace Projekt_ASP_NET.Models
{
    public class Hire
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ItemId { get; set; }
        public DateTime? StartOfHire { get; set; }
        public DateTime? EndOfHire { get; set; }
        public virtual Vehicle? Item { get; set; }
        public virtual User? User { get; set; }
    }
}
