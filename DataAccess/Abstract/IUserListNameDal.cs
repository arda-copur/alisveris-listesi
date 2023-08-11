using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IUserListNameDal : IRepository<UserProductListName>
    {
        List<UserProductListName> UserProductListNameId(int id);
    }
}
