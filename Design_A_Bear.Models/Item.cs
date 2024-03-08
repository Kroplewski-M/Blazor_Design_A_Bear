using System.ComponentModel.DataAnnotations;

namespace Design_A_Bear.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [MinLength(10)]
        public string Description { get; set; }
        [Required]
        [Range(1, 1000)]
        public float Price { get; set; }
        [Required]

        public string Category { get; set; }
        [Required]

        public string ImgBase64 { get; set; }

    }
}
