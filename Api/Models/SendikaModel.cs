using System.ComponentModel.DataAnnotations;

namespace Api.Models
{
    public class SendikaModel
    {
        [Key]
        public int ID { get; set; }
        public string SendikaID => $"SEN{ID}";
        public string? Sendika_Bilgisi { get; set; }
    }
}
