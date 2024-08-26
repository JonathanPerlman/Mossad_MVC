namespace Mossad_MVC.Models
{
    public class Agent
    {
        public int id { get; set; }
        public string photo_url { get; set; }
        public string nickname { get; set; }
        public Location? _Location { get; set; }
        public Enums.AgentStatus? Status { get; set; }
    }
}
