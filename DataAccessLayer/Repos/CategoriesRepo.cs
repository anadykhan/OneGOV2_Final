using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repos
{
    
        internal class CategoriesRepo : Repo, IRepo<Categories, int, Categories>
        {
            public Categories Create(Categories obj)
            {
                db.Categories.Add(obj);
                if (db.SaveChanges() > 0)
                    return obj;
                return null;
            }

            public bool Delete(int id)
            {
                var ex = Read(id);
                db.Categories.Remove(ex);
                return db.SaveChanges() > 0;
            }

            public List<Categories> Read()
            {
                return db.Categories.ToList();
            }

            public Categories Read(int id)
            {
                return db.Categories.Find(id);
            }

            public Categories Update(Categories obj)
            {
                var ex = Read(obj.CategoriID);
                db.Entry(ex).CurrentValues.SetValues(obj);
                if (db.SaveChanges() > 0) return obj;
                return null;
            }
        }
}
