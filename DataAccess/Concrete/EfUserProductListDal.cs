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
    public class EfUserProductListDal : EfCoreGenericRepository<UserProductList, AlisverisDbContext>, IUserProductList
    {
        public List<UserProductList> UserProductListNameId(int id)
        {
            using (var context = new AlisverisDbContext())
            {
                return context.UserProductLists.Include(p=>p.Product).Where(x => x.UserProductListNameId == id).ToList();
                
            }
        }
    }
}