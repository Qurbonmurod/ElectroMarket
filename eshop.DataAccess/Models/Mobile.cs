using eshop.DataAccess.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eshop.DataAccess.Models
{
    public class Mobile : Product
    {
          public MobileBrands Brand { get; set; }
    }
}
