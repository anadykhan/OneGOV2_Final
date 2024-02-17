using DataAccessLayer.Models;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repos
{
    internal class UserRepo : Repo, IRepo<User, string, User>, IAuth<bool>
    {
        public bool Authenticate(string username, string password)
        {
            var data = db.User.FirstOrDefault(u => u.UserName.Equals(username) &&
            u.Password.Equals(password));
            if (data != null) return true;
            return false;
        }
        public User Create(User obj)
        {
            db.User.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
        public List<User> Read()
        {
            return db.User.ToList();
        }
        public User Read(string id)
        {
            return db.User.Find(id);
        }
        public bool Delete(string id)
        {
            var ex = Read(id);
            db.User.Remove(ex);
            return db.SaveChanges() > 0;
        }
        public User Update(User obj)
        {
            var ex = Read(obj.UserName);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;

        }


    }
}
