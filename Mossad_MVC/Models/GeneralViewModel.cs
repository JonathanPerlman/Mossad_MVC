﻿using static Mossad_MVC.Models.Enums;

namespace Mossad_MVC.Models
{
    public class GeneralViewModel
    {
        public int AgentsCount { get; set; }
        public int AgentsInActivityCount { get; set; }
        public int TargetsCount { get; set; }
        public int TargetsKilledCount { get; set; }
        public int MissionsCount { get; set; }
        public int MissionsAssignedCount { get; set; }
        public Double RelationOfAgentsToTargets { get; set; }
        public Double RelationOfAvaliableAgentsToTargets { get; set; }
    }
}
