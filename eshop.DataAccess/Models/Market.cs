using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eshop.DataAccess.Models
{
    public class Market
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }


        [Required]
        public string Phone { get; set; }

        [Required]
        public string Location { get; set; }

        public string Email { get; set; }
        public string ImagePath { get; set; }
    }
}
