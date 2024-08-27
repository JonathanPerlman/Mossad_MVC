namespace Mossad_MVC.Models
{
    public class AgentViewModel
    {
        public int Id { get; set; }
        public string PhotoUrl { get; set; }
        public string NickName { get; set; }
        public Double AgentX { get; set; }
        public Double AgentY { get; set; }
        public Enums.AgentStatus? Status { get; set; }
        public int MissionId { get; set; }
        public Double? TimeLeft { get; set; }
        public int KillsCount { get; set; }
    }
}

