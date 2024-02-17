using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repos
{
    internal class UserOrderRepos : Repo, IRepo<UserOrder , int , UserOrder>
    {
        public UserOrder Create(UserOrder obj)
        {
            db.UserOder.Add(obj);
            if (db.SaveChanges() > 0)
                return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.UserOder.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<UserOrder> Read()
        {
            return db.UserOder.ToList();
        }

        public UserOrder Read(int id)
        {
            return db.UserOder.Find(id);
        }

        public UserOrder Update(UserOrder obj)
        {
            var ex = Read(obj.ID);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
