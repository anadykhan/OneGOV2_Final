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
    public class UserOrderService
    {
        public static List<UserOrderDTO> Get()
        {
            var data = DataAccessFactory.UserOrderData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<UserOrder, UserOrderDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<UserOrderDTO>>(data);
            return mapped;
        }
        public static UserOrderDTO Get(int id)
        {
            var data = DataAccessFactory.UserOrderData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<UserOrder, UserOrderDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<UserOrderDTO>(data);
            return mapped;
        }
        public static UserOrderDTO Create(UserOrderDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<UserOrder, UserOrderDTO>();
                c.CreateMap<UserOrderDTO, UserOrder>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<UserOrder>(obj);

            var result = DataAccessFactory.UserOrderData().Create(data);
            var redata = mapper.Map<UserOrderDTO>(result);
            return redata;
        }
        public static UserOrderDTO Delete(int Id)
        {
            var data = DataAccessFactory.UserOrderData().Delete(Id);

            return null;



        }
        public static UserOrderDTO Update(UserOrderDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<UserOrder, UserOrderDTO>();
                c.CreateMap<UserOrderDTO, UserOrder>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<UserOrder>(obj);
            var result = DataAccessFactory.UserOrderData().Update(data);
            var redata = mapper.Map<UserOrderDTO>(result);
            return redata;

        }
    }
}

