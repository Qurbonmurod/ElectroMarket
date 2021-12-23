using System;
using System.Collections.Generic;
using System.Text;

namespace eshop.DataAccess.Models
{
    public interface IBaseRepository<T>
    {
        T Create(T item);
        T GetItem(int id);
        IEnumerable<T> GetAllItems();
        T Update(T item);

        T Delete(int id);

    }
}
