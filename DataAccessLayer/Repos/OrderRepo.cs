using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer.Repos
{
    internal class OrderRepo : Repo, IRepo<Orders, int, Orders>
    {
        public Orders Create(Orders obj)
        {
            db.Orders.Add(obj);
            if (db.SaveChanges() > 0)
                return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.Orders.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Orders> Read()
        {
            return db.Orders.ToList();
        }

        public Orders Read(int id)
        {
            return db.Orders.Find(id);
        }

        public Orders Update(Orders obj)
        {
            var ex = Read(obj.OrderID);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    
       
    }
}
