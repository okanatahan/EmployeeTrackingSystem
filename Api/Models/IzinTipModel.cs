using System.ComponentModel.DataAnnotations;

namespace Api.Models
{
    public class IzinTipModel
    {
        [Key]
        public int ID { get; set; }
        public string? IZIN_TIPI { get; set; }
    }
}
