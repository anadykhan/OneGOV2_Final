using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Cart
    {
        [Key]
        public int CartID { get; set; }
        public string UserName { get; set; }
        public int ProductID { get; set; }
    }
}