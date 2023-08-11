﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User
    {
       
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string  Email { get; set; }
        public string Password { get; set; }
        public string PasswordCheck { get; set; }
        public virtual List<UserProductListName> UserProductListName { get; set; }
    }
}