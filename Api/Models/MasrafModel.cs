using System.ComponentModel.DataAnnotations;

namespace Api.Models
{
    public class MasrafModel
    {
        [Key]
        public int ID { get; set; }
        public string MasrafID => $"MAS{ID}";
        public string? Masraf_Bilgisi { get; set; }
    }
}
