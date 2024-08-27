using static Mossad_MVC.Models.Enums;

namespace Mossad_MVC.Models
{
    public class MissionViewModel
    {
        public int Id { get; set; }
        public string AgentName { get; set; }
        public Double AgentX { get; set; }
        public Double AgentY { get; set; }
        public string TargetName { get; set; }
        public Double TargetX { get; set; }
        public Double TaregtY { get; set; }
        public Double Distance { get; set; }
        public MissionStatus? Status { get; set; }
        public Double? TimeLeft { get; set; }
    }

}
