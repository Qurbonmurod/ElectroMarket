using System;
using System.Collections.Generic;
using System.Text;

namespace eshop.DataAccess.Models
{
    public class MarketRepository:IRepository<Market>
    {
        private AppDbContext dbContext;

        public MarketRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Market item)
        {
            dbContext.Market.Add(item);
        }

        public void Delete(int id)
        {
            Market market = dbContext.Market.Find(id);

            if(market != null)
            {
                dbContext.Market.Remove(market);
            }
        }

        public Market Get(int id)
        {
            return dbContext.Market.Find(id);
        }

        public IEnumerable<Market> GetAll()
        {
            return dbContext.Market;
        }

        public void Update(Market item)
        {
            dbContext.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
