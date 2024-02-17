using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repos
{
    internal class UserBookingRepo : Repo, IRepo<UserBooking, int, UserBooking>
    {
        public UserBooking Create(UserBooking obj)
        {
            db.UserBookings.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.UserBookings.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<UserBooking> Read()
        {
            return db.UserBookings.ToList();
        }

        public UserBooking Read(int id)
        {
            return db.UserBookings.Find(id);
        }

        public UserBooking Update(UserBooking obj)
        {
            var ex = Read(obj.BookingID);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }
    }
}