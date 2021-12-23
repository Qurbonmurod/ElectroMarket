using System;
using System.Collections.Generic;
using System.Text;

namespace eshop.DataAccess.Models
{
    public class ComputerRepository : IComputerRepository
    {
        private readonly AppDbContext dbContext;

        public ComputerRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        T IComputerRepository.Create(T computer)
        {
            dbContext.Computers.Add(computer);
            dbContext.SaveChanges();
            return computer;
        }

        T IComputerRepository.Delete(int id)
        {
            var computer = dbContext.Computers.Find(id);
            if(computer != null)
            {
                dbContext.Computers.Remove(computer);
                dbContext.SaveChanges();
            }
            return computer;
        }

        IEnumerable<T> IComputerRepository.GetAllComputers()
        {
            return dbContext.Computers;
        }

        T IComputerRepository.GetComputer(int id)
        {
            return dbContext.Computers.Find(id);
        }

        T IComputerRepository.Update(T updatecomputer)
        {
            var computer = dbContext.Computers.Attach(updatecomputer);
            computer.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();
            return updatecomputer;
        }
    }
}
