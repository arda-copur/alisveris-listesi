using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class UserProductList
    {
     
        public int Id { get; set; }
        public UserProductListName UserProductListName { get; set; }
        public int UserProductListNameId { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
     

    }
}
