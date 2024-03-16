using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceApiCSharp.Models
{
    [Table("statuses")]
    public class Status
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("name")]
        public string Name { get; set; }

        [Required]
        [Column("model")]
        public string Model { get; set; }

        [Required]
        [Column("color_status")]
        public string ColorStatus { get; set; }

        [Required]
        [Column("translation_status")]
        public string TranslationStatus { get; set; }
    }
}
