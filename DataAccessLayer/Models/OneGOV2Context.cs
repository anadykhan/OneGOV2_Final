using DataAccessLayer.Models;


using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    internal class OneGOV2Context : DbContext
    {
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<UserOrder> UserOder { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<UserBooking> UserBookings { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<Token> Token { get; set; }
        public DbSet<ProductReview> ProductReview { get; set; }
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<UserReview> UserReviews { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<WishProduct> WishProduct { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Cart> Carts { get; set; }

    }
}
