using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.DTOs
{
    public class ProductsDTO
    {
        
        public int ProductId { get; set; }
       
        public string Title { get; set; }

        public string SubTittle { get; set; }
        
        public double Rating { get; set; }
       
        public int Price { get; set; }
    
        public int CategoryId { get; set; }
    }
}
