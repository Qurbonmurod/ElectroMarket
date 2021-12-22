using System;
using System.Collections.Generic;
using System.Text;

namespace eshop.DataAccess.Models
{
    public interface IMobileRepository
    {
        Mobile GetMobile(int id);

        IEnumerable<Mobile> GetAllMobiles();

        Mobile Create(Mobile mobile);

        Mobile Update(Mobile mobile);

        Mobile Delete(int id);
    }
}
