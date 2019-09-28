﻿using System.ComponentModel.DataAnnotations;

namespace Oblig1WebApp.Models
{
    public class Avgang
    {
        public int id { get; set; }
        [Display(Name = "Første avgang")]
        public string forsteAvgang { get; set; }
        [Display(Name = "Siste avgang")]
        public string sisteAvgang { get; set; }
        [Display(Name = "Reisetid")]
        public string reiseTid { get; set; }
        [Display(Name = "Spor")]
        public string spor { get; set; }
        [Display(Name = "Tognummer")]
        public string togNummer { get; set; }
    }

    public class jsAvgang
    {
        public int id { get; set; }
        public string forsteAvgang { get; set; }
        public string sisteAvgang { get; set; }
    }
}