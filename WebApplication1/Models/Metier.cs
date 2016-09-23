using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("Metiers")]
    public class Metier
    {
        public int ID { get; set; }
        [Required, MaxLength(255)]
        public string Title { get; set; }
    }
}