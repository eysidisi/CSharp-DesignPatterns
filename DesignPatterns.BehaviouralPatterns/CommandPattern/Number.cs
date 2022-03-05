﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralPatterns.CommandPattern
{
    public class Number
    {
        public int Val { get; set; }
        public override string ToString()
        {
            return Val.ToString(); 
        }
    }
}
