namespace Mossad_MVC.Models
{
    public class TargetViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Position { get; set; }
        public string PhotoUrl { get; set; }
        public Double TargetX { get; set; }
        public Double TargetY { get; set; }

        public Enums.TargetStatus? Status { get; set; }
    }
}
