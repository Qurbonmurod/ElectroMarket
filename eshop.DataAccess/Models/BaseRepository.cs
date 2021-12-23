using System;
using System.Collections.Generic;
using System.Text;

namespace eshop.DataAccess.Models
{
    public class BaseRepository<T> : IBaseRepository<T>
    {
        private readonly AppDbContext dbContext;

        public BaseRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        T IBaseRepository<T>.Create(T item)
        {
            
        }

        T IBaseRepository<T>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<T> IBaseRepository<T>.GetAllItems()
        {
            throw new NotImplementedException();
        }

        T IBaseRepository<T>.GetItem(int id)
        {
            throw new NotImplementedException();
        }

        T IBaseRepository<T>.Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
