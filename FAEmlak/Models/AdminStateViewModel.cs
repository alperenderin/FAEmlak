﻿using System;
using System.Collections.Generic;
using FAEmlak.Entity;

namespace FAEmlak.Models
{
    public class AdminStateViewModel
    {
        public State state { get; set; }
        public List<City> cities { get; set; }
    }
}
