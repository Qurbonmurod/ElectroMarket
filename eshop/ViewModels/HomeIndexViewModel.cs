using eshop.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eshop.ViewModels
{
    public class HomeIndexViewModel
    {
        public Accessories Accessor { get; set; }
        public Market Market { get; set; }
        public Printer Printer { get; set; }
        public Laptop Laptop { get; set; }
        public ComputerDetail ComputerDetail { get; set; }
        public string Title { get; set; }
    }
}
