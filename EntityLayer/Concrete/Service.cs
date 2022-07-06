using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Service
    {
        [Key]
        public int ServiceID { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        [StringLength(200)]
        public string İcon { get; set; }
    }
}
