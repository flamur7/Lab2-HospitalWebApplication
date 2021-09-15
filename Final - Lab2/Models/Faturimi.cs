﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Final___Lab2.Models
{
    public class Faturimi
    {
        [Key]
        public int FaturimiId { get; set; }

        [ForeignKey("Pacient")]
        public int PacientiId { get; set; }
        public virtual Pacient Pacient { get; private set; }

        [ForeignKey("Faktura")]
        public int FakturaId { get; set; }
        public virtual Faktura Faktura { get; private set; }

        [ForeignKey("Terapia")]
        public int TerapiaId { get; set; }
        public virtual Terapi Terapi { get; private set; }

        public string KohaPageses { get; set; }
        public int Kestet { get; set; }
    }
}