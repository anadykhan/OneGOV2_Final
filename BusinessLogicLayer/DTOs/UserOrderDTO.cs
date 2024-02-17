using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLogicLayer.DTOs
{
    public class UserOrderDTO
    {

        public int ID { get; set; }
      
       public string OrderBy { get; set; }


        public int Price { get; set; }

        public string Decision { get; set; }
    }
}
