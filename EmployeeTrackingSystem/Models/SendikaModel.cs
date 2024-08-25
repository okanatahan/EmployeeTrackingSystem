using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTrackingSystem.Models
{
    public class SendikaModel
    {
        [Key]
        public int ID { get; set; }
        public string SendikaID => $"SEN{ID}";
        public string Sendika_Bilgisi { get; set; }
    }
}
