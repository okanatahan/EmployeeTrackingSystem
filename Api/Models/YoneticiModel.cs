using System.ComponentModel.DataAnnotations;

namespace Api.Models
{
    public class YoneticiModel
    {
        [Key]
        public int YoneticiID { get; set; }
        public int? FK_PersonelID { get; set; }
        public string? AD { get; set; }
        public string? SOYAD { get; set; }
        public string? AD_SOYAD => $"{AD} {SOYAD}";
    }
}
