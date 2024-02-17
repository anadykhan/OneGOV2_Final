using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class UserOrder
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("User")]
        public string OrderBy { get; set; }
     
       
        public int Price { get; set; }
    
        public string Decision { get; set; }

        public virtual User User { get; set; }

    }
}
