﻿using System.ComponentModel.DataAnnotations;

namespace EmployeeTrackingSystem.Models
{
    public class KullaniciModel
    {
        [Key]
        public int FK_PersonelID { get; set; }
        public string kullanıcı_adı { get; set; }
        public string parola { get; set; }
        public string rol { get; set; }
    }
}
