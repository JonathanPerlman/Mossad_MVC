namespace Mossad_MVC.Models
{
    public class Target
    {
        public int id { get; set; }

        public string name { get; set; }
        public string position { get; set; }
        public string photo_url { get; set; }
        public Location? _Location { get; set; }

        public Enums.TargetStatus? Status { get; set; }
    }
}
