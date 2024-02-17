using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repos
{
    
        internal class ProductsRepo : Repo, IRepo<Products, string, Products>
        {
            public Products Create(Products obj)
            {
                db.Products.Add(obj);
                if (db.SaveChanges() > 0)
                    return obj;
                return null;
            }

            public bool Delete(string ID)
            {
                var ex = Read(ID);
                db.Products.Remove(ex);
                return db.SaveChanges() > 0;
            }

            public List<Products> Read()
            {
                return db.Products.ToList();
            }

            public Products Read(string id)
            {
                return db.Products.Find(id);
            }

            public Products Update(Products obj)
            {
                var ex = Read(obj.Title);
                db.Entry(ex).CurrentValues.SetValues(obj);
                if (db.SaveChanges() > 0) return obj;
                return null;
            }


        }
    }

