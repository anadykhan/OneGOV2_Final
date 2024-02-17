
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
    internal class CommentRepo : Repo, IRepo<Comment, int, Comment>
    {
        public Comment Create(Comment obj)
        {
            db.Comment.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.Comment.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Comment> Read()
        {
            return db.Comment.ToList();
        }

        public Comment Read(int id)
        {
            return db.Comment.Find(id);
        }

        public Comment Update(Comment obj)
        {
            var ex = Read(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;

        }
    }

}