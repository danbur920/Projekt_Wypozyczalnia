namespace Projekt_ASP_NET.Models
{
    public class HireViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ItemId { get; set; }
        public DateTime StartOfHire { get; set; }
        public DateTime EndOfHire { get; set; }
        public virtual ItemViewModel Item { get; set; }
        public virtual UserViewModel User { get; set; }
    }
}
