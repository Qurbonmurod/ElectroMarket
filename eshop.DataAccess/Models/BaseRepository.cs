using System;
using System.Collections.Generic;
using System.Text;

namespace eshop.DataAccess.Models
{
    public class BaseRepository<T> : IBaseRepository<T> where T: class
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
            
        }

        IEnumerable<T> IBaseRepository<T>.GetAllItems()
        {
            
        }

        T IBaseRepository<T>.GetItem(int id)
        {
            
        }

        T IBaseRepository<T>.Update(T item)
        {
            
        }
    }
}
