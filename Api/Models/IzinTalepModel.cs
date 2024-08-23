﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Api.Models
{
    [Keyless]
    public class IzinTalepModel
    {
        public int FK_PersonelID { get; set; }
        public string? Ad_Soyad { get; set; }
        public DateTime IzinBaslangicTar { get; set; }
        public DateTime IzinBitisTar { get; set; }
        public string? FK_IzinTipi { get; set; }
        public int FK_YoneticiID { get; set; }
        public string? Yonetici { get; set; }
        public string? OnayDurumu { get; set; }
    }
}
