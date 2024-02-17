using DataAccessLayer.Models;
using DataAccessLayer.Repos;
using DataAccessLayer.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer
{
    public class DataAccessFactory
    {
        public static IRepo<Products, string, Products> ProductData()
        {
            return new ProductsRepo();
        }
        public static IRepo<Orders, int, Orders> OrderData()
        {
            return new OrderRepo();
        }
        public static IRepo<Categories, int, Categories> CategoriesData()
        {
            return new CategoriesRepo();
        }
        public static IRepo<UserOrder, int, UserOrder> UserOrderData()
        {
            return new UserOrderRepos();
        }
        public static IRepo<Room, int, Room> RoomData()
        {
            return new RoomRepo();
        }

        public static IRepo<UserBooking, int, UserBooking> UserBookingData()
        {
            return new UserBookingRepo();
        }
        public static IRepo<Blog, int, Blog> BlogData()
        {
            return new BlogRepo();
        }
        public static IRepo<Comment, int, Comment> CommentData()
        {
            return new CommentRepo();
        }
        public static IRepo<ProductReview, int, ProductReview> ProductReviewData()
        {
            return new ProductReviewRepo();
        }

        public static IRepo<Token, string, Token> TokenData()
        {
            return new TokenRepo();
        }
        public static IRepo<Hotel, int, Hotel> HotelData()
        {
            return new HotelRepo();
        }

        public static IRepo<WishProduct, int, WishProduct> WishProductData()
        {
            return new WishProductRepo();
        }

        public static IRepo<Event, int, Event> EventData()
        {
            return new EventRepo();
        }

        public static IRepo<UserReview, int, UserReview> UserReviewData()
        {
            return new UserReviewRepo();
        }
        public static IRepo<User, string, User> UserData()
        {
            return new UserRepo();
        }
        public static IAuth<bool> AuthData()
        {
            return new UserRepo();
        }
        public static IRepo<Like, int, Like> LikeData()
        {
            return new LikeRepo();
        }

        public static IRepo<Cart, int, Cart> CartData()
        {
            return new CartRepo();
        }
    }
}
