using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Text;

namespace eshop.DataAccess.Models
{
    public interface IComputerRepository
    {
        T GetComputer(int id);

        IEnumerable<T> GetAllComputers();

        T Create(T computer);

        T Update(T computer);

        T Delete(int id);

    }
}
