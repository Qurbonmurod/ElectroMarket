using System;
using System.Collections.Generic;
using System.Text;

namespace eshop.DataAccess.Models
{
    public class UnitOfWork : IDisposable
    {
        public AppDbContext dbContext;

        public MarketRepository marketRepository;

        public MarketRepository Market
        {
            get
            {
                if (marketRepository == null)
                    marketRepository = new MarketRepository(dbContext);
                return marketRepository;
            }
        }

        public void Save()
        {
            dbContext.SaveChanges();
        }

        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    dbContext.Dispose();
                }

                this.disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
