using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Design_A_Bear.Models
{
    public class FavoriteItems
    {
        [Key]
        public int Id { get; set; }

        public string UserId { get; set; }

        public Item Item { get; set; }
        public int ItemId { get; set; }
    }
}
