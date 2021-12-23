using eshop.DataAccess.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eshop.DataAccess.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Cost { get; set; } //Mahsulot tannarxi

        [Required]
        public int Price { get; set; } //Sotilish bahosi
            
        public string Description { get; set; } //Qisqacha izohi
        public Categories Category { get; set; } //Kategoriyasi
        public int Count { get; set; } //Keltirilgan soni
        public Colors Color { get; set; } //Rangi
        public int ImagePath { get; set; } //Rasmining joylashgan yo'li
        public int Massa { get; set; } //Og'irligi
    }
}
