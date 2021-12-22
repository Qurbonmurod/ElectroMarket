using System;
using System.Collections.Generic;
using System.Text;

namespace eshop.DataAccess.Models
{
    public interface IComputerRepository
    {
        Computer GetComputer(int id);

        IEnumerable<Computer> GetAllComputers();

        Computer Create(Computer computer);

        Computer Update(Computer computer);

        Computer Delete(int id);

    }
}
