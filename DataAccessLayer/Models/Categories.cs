using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer.Models
{
    public class Categories
    {
        [Key]
        public int CategoriID { get; set; }
        [Required]
        public string CategoriName { get; set; }


    }
}
