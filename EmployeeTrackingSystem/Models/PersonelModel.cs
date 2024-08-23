using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTrackingSystem.Models
{
    public class PersonelModel
    {
        public int PersonelID { get; set; }
        public string SICIL { get; set; }
        public string AD { get; set; }
        public string SOYAD { get; set; }
        public string AD_SOYAD => $"{AD} {SOYAD}";
        public string CINSIYET { get; set; }
        public DateTime? DOGUM_TAR { get; set; }
        public DateTime? GIRIS_TAR { get; set; }
        public DateTime? CIKIS_TAR { get; set; }
        public string UNVAN { get; set; }
        public string YAKA { get; set; }
        public string ISLETME_KOD { get; set; }
        public string DEPARTMAN_KOD { get; set; }
        public string DEPARTMAN_ALT_KOD { get; set; }
        public string POZISYON_KOD { get; set; }
        public string LOKASYON_KOD { get; set; }
        public string GECIS_KOD { get; set; }
        public bool? SENKRON { get; set; }
        public string SENDIKA_KOD { get; set; }
        public string TASERON_KOD { get; set; }
        public string CALISMA_SEKLI { get; set; }
        public string CALISMA_KONUMU { get; set; }
        public string DURUM { get; set; }
        public string SICIL_EK { get; set; }
        public string SGK_NO { get; set; }
        public string MASRAF_KODU { get; set; }
        public int FK_YoneticiID { get; set; }
    }
}
