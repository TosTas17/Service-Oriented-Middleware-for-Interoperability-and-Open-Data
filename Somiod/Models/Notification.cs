﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Somiod.Models
{
    public class Notification
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime creation_datetime { get; set; }
        public int parent { get; set; }
        public byte @event { get; set; }
        public string endpoint { get; set; }

        public int enabled { get; set; } //devia ser bit
        public string res_type { get; set; }

    }
}