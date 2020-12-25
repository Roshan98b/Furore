﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheGameBackend.Models
{
    public class Participant
    {
        public string roomCode { get; set; }

        public string participantName { get; set; }

        public int score { get; set; }

        public bool isReady { get; set; }
    }
}
