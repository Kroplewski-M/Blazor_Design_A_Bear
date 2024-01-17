using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_A_Bear.Models
{
    public class Item
    {
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
