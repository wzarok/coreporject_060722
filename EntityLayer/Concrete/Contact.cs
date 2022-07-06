﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [StringLength(100)]
        public string Mail { get; set; }
        [StringLength(100)]
        public string Phone { get; set; }
    }
}
