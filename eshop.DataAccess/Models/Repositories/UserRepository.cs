using System;
using System.Collections.Generic;
using System.Text;

namespace eshop.DataAccess.Models
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext dbContext;

        public UserRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        User IUserRepository.Create(User user)
        {
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
            return user;
        }

        User IUserRepository.Delete(int id)
        {
            var user = dbContext.Users.Find(id);
            if (user != null)
            {
                dbContext.Remove(user);
                dbContext.SaveChanges();
            }

            return user;
        }

        IEnumerable<User> IUserRepository.GetAllUsers()
        {
            return dbContext.Users;
        }

        User IUserRepository.GetUser(int id)
        {
            return dbContext.Users.Find(id);
        }

        User IUserRepository.Update(User updateuser)
        {
            var user = dbContext.Users.Attach(updateuser);
            user.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();
            return updateuser;
        }
    }
}
