using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Product
    {

        [Key]
        public int Id { get; set; }
        public string ÜrünAdı { get; set;}
        public int Miktar { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public virtual List<UserProductList> UserProductLists { get; set; }
    }
}
