using System;
using System.Collections.Generic;
using System.Text;

namespace eshop.DataAccess.Models
{
    public class MobileRepository : IMobileRepository
    {
        private readonly AppDbContext dbContext;

        public MobileRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        Mobile IMobileRepository.Create(Mobile mobile)
        {
            dbContext.Mobiles.Add(mobile);
            dbContext.SaveChanges();
            return mobile;
        }

        Mobile IMobileRepository.Delete(int id)
        {
            var mobile = dbContext.Mobiles.Find(id);
            if(mobile != null)
            {
                dbContext.Remove(mobile);
                dbContext.SaveChanges();
            }
            return mobile;
        }

        IEnumerable<Mobile> IMobileRepository.GetAllMobiles()
        {
            return dbContext.Mobiles;
        }

        Mobile IMobileRepository.GetMobile(int id)
        {
            return dbContext.Mobiles.Find(id);
        }

        Mobile IMobileRepository.Update(Mobile updatemobile)
        {
            var mobile = dbContext.Mobiles.Attach(updatemobile);
            mobile.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();
            return updatemobile;
        }
    }
}
