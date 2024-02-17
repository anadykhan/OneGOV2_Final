using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.DTOs
{
    public class RoomDTO
    {
        public int RoomID { get; set; }
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }
        public string AvailabilityStatus { get; set; }
        public string ImageURL { get; set; }
        public int HotelNumber { get; set; }
    }
}
