using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.DTOs
{
    public class OrdersDTO
    {

        
        public int OrderID { get; set; }
      
        public string OrderBy { get; set; }
       
        public int ProductID { get; set; }
       
        public string ProductName { get; set; }
        
        public int Price { get; set; }
       
        public string Status { get; set; }
    }
}
