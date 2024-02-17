using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using DataAccessLayer.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repos
{
    internal class BlogRepo : Repo, IRepo<Blog, int, Blog>
    {
        public Blog Create(Blog obj)
        {
            db.Blog.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.Blog.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Blog> Read()
        {
            return db.Blog.ToList();
        }

        public Blog Read(int id)
        {
            return db.Blog.Find(id);
        }

        public Blog Update(Blog obj)
        {
            var ex = Read(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

    }
}