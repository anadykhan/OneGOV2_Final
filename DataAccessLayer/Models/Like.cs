using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Like
    {
        [Key]
        public int LikeID { get; set; }
        [ForeignKey("User")]
        public string UserName { get; set; }
        [ForeignKey("Blog")]
        public int BlogID { get; set; }
       
        public virtual User User { get; set; }
        public virtual Blog Blog { get; set; }
    }
}