
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
    internal class ProductReviewRepo : Repo, IRepo<ProductReview, int, ProductReview>
    {
        public ProductReview Create(ProductReview obj)
        {
            db.ProductReview.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.ProductReview.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<ProductReview> Read()
        {
            return db.ProductReview.ToList();
        }

        public ProductReview Read(int id)
        {
            return db.ProductReview.Find(id);
        }

        public ProductReview Update(ProductReview obj)
        {
            var ex = Read(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }

}