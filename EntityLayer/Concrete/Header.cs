﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Header
    {
        [Key]
        public int HeaderID { get; set; }
        [StringLength(100)]
        public string HeaderTitle { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(250)]
        public string Title { get; set; }
    }
}
