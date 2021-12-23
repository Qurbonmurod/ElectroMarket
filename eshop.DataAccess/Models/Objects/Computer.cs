using eshop.DataAccess.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eshop.DataAccess.Models
{
    public class T : Product
    {
        public ComputerBrands Brand { get; set; }
    }
}
