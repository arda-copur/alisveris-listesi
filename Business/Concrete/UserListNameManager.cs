using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserListNameManager : IUserListService
    {
        IUserListNameDal _userListNameDal;

        public UserListNameManager(IUserListNameDal userListNameDal)
        {
            _userListNameDal = userListNameDal;
        }

        public List<UserProductListName> GetList()
        {
            return _userListNameDal.GetAll();
        }

        public void TAdd(UserProductListName t)
        {
            _userListNameDal.Add(t);    
        }

        public void TDelete(UserProductListName t)
        {
            _userListNameDal.Delete(t);
        }

        public UserProductListName TGetById(int id)
        {
            return _userListNameDal.GetByID(id);
        }

        public void TUpdate(UserProductListName t)
        {
            _userListNameDal.Update(t);
        }

        public List<UserProductListName> UserProductListName(int id)
        {
            return _userListNameDal.UserProductListNameId(id);
        }
    }
}
