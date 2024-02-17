
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
    public class UserBooking
    {
        [Key]
        public int BookingID { get; set; }
       
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public double TotalPrice { get; set; }
        public string BookingStatus { get; set; }
        [ForeignKey("User")]
        public string BookBy { get; set; }
        public virtual User User { get; set; }  
        [ForeignKey("Hotel")]
        public int HotelID { get; set; }
        public virtual Hotel Hotel { get; set; }

        [ForeignKey("Room")]
        public int RoomID { get; set; }
        public virtual Room Room { get; set; }
        
       



       
      
       
    }
}
