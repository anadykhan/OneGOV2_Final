using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string SubTittle { get; set; }
        [Required]
        public double Rating { get; set; }
        [Required]
        public int Price { get; set; }
        [ForeignKey("Categories")]
        public int CategoriId { get; set; }

        public virtual Categories Categories { get; set; }  

    }
}
