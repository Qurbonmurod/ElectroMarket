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

        Computer IComputerRepository.Create(Computer computer)
        {
            dbContext.Computers.Add(computer);
            dbContext.SaveChanges();
            return computer;
        }

        Computer IComputerRepository.Delete(int id)
        {
            var computer = dbContext.Computers.Find(id);
            if(computer != null)
            {
                dbContext.Computers.Remove(computer);
                dbContext.SaveChanges();
            }
            return computer;
        }

        IEnumerable<Computer> IComputerRepository.GetAllComputers()
        {
            return dbContext.Computers;
        }

        Computer IComputerRepository.GetComputer(int id)
        {
            return dbContext.Computers.Find(id);
        }

        Computer IComputerRepository.Update(Computer updatecomputer)
        {
            var computer = dbContext.Computers.Attach(updatecomputer);
            computer.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();
            return updatecomputer;
        }
    }
}
