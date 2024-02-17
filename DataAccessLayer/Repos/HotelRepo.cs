
using DataAccessLayer.Interfaces;
using DataAccessLayer.Repos;
using System.Collections.Generic;
using System.Linq;
using DataAccessLayer.Models;

namespace DataAccessLayer.Repos
{
    internal class HotelRepo : Repo, IRepo<Hotel, int, Hotel>
    {
        public Hotel Create(Hotel obj)
        {
            db.Hotel.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public List<Hotel> Read()
        {
            return db.Hotel.ToList();
        }

        public Hotel Read(int id)
        {
            return db.Hotel.Find(id);
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.Hotel.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public Hotel Update(Hotel obj)
        {
            var ex = Read(obj.HotelID);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}