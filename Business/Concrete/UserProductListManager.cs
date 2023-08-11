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
    public class UserProductListManager : IUserProductListService
    {
        IUserProductList _userProducList;

        public UserProductListManager(IUserProductList userProducList)
        {
            _userProducList = userProducList;
        }

        public List<UserProductList> GetList()
        {
            return _userProducList.GetAll();
        }

        public void TAdd(UserProductList t)
        {
           _userProducList.Add(t);
        }

        public void TDelete(UserProductList t)
        {
            _userProducList.Delete(t);
        }

        public UserProductList TGetById(int id)
        {
            return _userProducList.GetByID(id);
        }

        public void TUpdate(UserProductList t)
        {
            _userProducList.Update(t);
        }

        public List<UserProductList> UserProductList(int id)
        {
            return _userProducList.UserProductListNameId(id);
        }
    }
}
