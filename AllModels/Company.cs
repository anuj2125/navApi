﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Company
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public bool IsActive { get; set; }

        public virtual List<User> Users { get; set; }
    }
}
