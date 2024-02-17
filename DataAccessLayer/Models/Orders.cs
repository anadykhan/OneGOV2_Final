
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Orders
    {
        [Key]
        public int OrderID { get; set; }
        [ForeignKey("User")]
        public string OrderBy { get; set; }
        [ForeignKey("Products")]
        public int ProductID { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public string Status { get; set; }

        public virtual User User { get; set; }
        public virtual Products Products { get; set; }
    }
}
