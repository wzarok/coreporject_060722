using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Experience
    {
        [Key]
        public int ExperienceID { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public DateTime DateLast { get; set; }
        [StringLength(200)]
        public string Image { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
    }
}
