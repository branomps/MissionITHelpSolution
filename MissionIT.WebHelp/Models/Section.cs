﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace MissionIT.WebHelp.Models
{
    public class Section
    {
        [Key]
        [ScaffoldColumn(false)]
        public int SectionID { get; set; }
        [Required, StringLength(100), Display(Name = "Name")]
        public string SectionName { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
    }
}
