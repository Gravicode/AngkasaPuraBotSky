﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngkasaPura.BotSkyApp.Model
{
    public class BotMessageRoot
    {
        public List<BotMessage> Messages { get; set; }
        public string Watermark { get; set; }
    }
}
