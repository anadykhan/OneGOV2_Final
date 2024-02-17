
using DataAccessLayer.Models;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Repos;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer.Repos
{
    internal class EventRepo : Repo, IRepo<Event, int, Event>
    {
        public Event Create(Event obj)
        {
            db.Event.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.Event.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Event> Read()
        {
            return db.Event.ToList();
        }

        public Event Read(int id)
        {
            return db.Event.Find(id);
        }

        public Event Update(Event obj)
        {
            var ex = Read(obj.EventID);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}