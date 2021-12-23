using eshop.DataAccess.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eshop.DataAccess.Models
{
    public class Computer : Product
    {
        public ComputerBrands Brand { get; set; }
    }
}
