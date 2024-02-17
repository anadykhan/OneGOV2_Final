using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repos
{
    internal class LikeRepo : Repo, IRepo<Like, int, Like>
    {
        public Like Create(Like obj)
        {
            db.Likes.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.Likes.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Like> Read()
        {
            return db.Likes.ToList();
        }

        public Like Read(int id)
        {
            return db.Likes.Find(id);
        }

        public Like Update(Like obj)
        {
            var ex = Read(obj.LikeID);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }
    }
}