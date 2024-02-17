using AutoMapper;
using BusinessLogicLayer.DTOs;
using DataAccessLayer.Models;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class CartService
    {
        public static List<CartDTO> Get()
        {
            var data = DataAccessFactory.CartData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Cart, CartDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<CartDTO>>(data);
            return mapped;
        }

        public static CartDTO GetById(int id)
        {
            var data = DataAccessFactory.CartData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Cart, CartDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<CartDTO>(data);
            return mapped;
        }

        public static CartDTO Create(CartDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Cart, CartDTO>();
                c.CreateMap<CartDTO, Cart>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<Cart>(obj);

            var result = DataAccessFactory.CartData().Create(data);
            var redata = mapper.Map<CartDTO>(result);
            return redata;
        }

        public static CartDTO Update(CartDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Cart, CartDTO>();
                c.CreateMap<CartDTO, Cart>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<Cart>(obj);
            var result = DataAccessFactory.CartData().Update(data);
            var redata = mapper.Map<CartDTO>(result);
            return redata;

        }

        public static CartDTO Delete(int Id)
        {
            var data = DataAccessFactory.CartData().Delete(Id);

            return null;
        }
    }
}