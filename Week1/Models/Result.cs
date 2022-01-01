﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Week1.Models
{
    public class Result
    {
        public int Status { get; set; }

        public string Message { get; set; }

        public List<Airplane>? AirplaneList { get; set; }
    }
}
