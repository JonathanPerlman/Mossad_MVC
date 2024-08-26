namespace Mossad_MVC.Models
{
    public class Mission
    {
        public int Id { get; set; }
        public Agent _agent { get; set; }
        public Target _target { get; set; }
        public double? TimeLeft { get; set; }
        public double? ActualExecutionTime { get; set; }
        public Enums.MissionStatus? Status { get; set; }
    }
}
