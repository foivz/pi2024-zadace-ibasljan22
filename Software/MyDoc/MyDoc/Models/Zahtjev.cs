﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace MyDoc.Models
{
    public class Zahtjev
    {
        public int ID { get; set; }

        public string VrijemeTermina {  get; set; }
        public string Obrazloženje { get; set; }
        public string MogučnostVideopoziva { get; set; }
        public int IDPacijent {  get; set; }

    }

}
