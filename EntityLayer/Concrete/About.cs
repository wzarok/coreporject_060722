using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int AboutID { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        [StringLength(500)]
        public string Details {get; set; }
        [StringLength(100)]
        public string Age {get; set; }
        [StringLength(100)]
        public string Mail {get; set; }
        [StringLength(100)]
        public string Phone {get; set; }
        [StringLength(200)]
        public string Adress {get; set; }
        [StringLength(200)]
        public string Image {get; set; }
    }
}
