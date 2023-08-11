using DataAccess.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfUserListNameDal : EfCoreGenericRepository<UserProductListName, AlisverisDbContext>, IUserListNameDal
    {
        public List<UserProductListName> UserProductListNameId(int id)
        {
            using (var context = new AlisverisDbContext())
            {
                return context.UserProductListNames.Where(x => x.UserId == id).ToList();

            }
        }
    }
}
