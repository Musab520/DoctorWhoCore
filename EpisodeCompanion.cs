﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db
{
    public class EpisodeCompanion
    {
        public int EpisodeCompanionId { get; set; }
        public Episode episode { get; set; }
        public Companion companion { get; set; }
    }
}
