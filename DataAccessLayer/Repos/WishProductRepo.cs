
using DataAccessLayer.Models;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Repos;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer.Repos
{
    internal class WishProductRepo : Repo, IRepo<WishProduct, int, WishProduct>
    {
        public WishProduct Create(WishProduct obj)
        {
            db.WishProduct.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.WishProduct.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<WishProduct> Read()
        {
            return db.WishProduct.ToList();
        }

        public WishProduct Read(int id)
        {
            return db.WishProduct.Find(id);
        }

        public WishProduct Update(WishProduct obj)
        {
            var ex = Read(obj.WishlistID);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}