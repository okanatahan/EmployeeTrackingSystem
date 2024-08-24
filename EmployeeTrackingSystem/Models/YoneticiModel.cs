﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTrackingSystem.Models
{
    public class YoneticiModel
    {
        [Key]
        public int YoneticiID { get; set; }
        public int FK_PersonelID { get; set; }
        public string AD { get; set; }
        public string SOYAD { get; set; }
        public string AD_SOYAD => $"{AD} {SOYAD}";
    }
}
