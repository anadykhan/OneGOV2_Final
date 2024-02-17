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
    public class OrderService
    {
        public static List<OrdersDTO> Get()
        {
            var data = DataAccessFactory.OrderData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Orders, OrdersDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<OrdersDTO>>(data);
            return mapped;
        }
        public static OrdersDTO Get(int id)
        {
            var data = DataAccessFactory.OrderData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Orders, OrdersDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<OrdersDTO>(data);
            return mapped;
        }
        public static OrdersDTO Create(OrdersDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Orders, OrdersDTO>();
                c.CreateMap<OrdersDTO, Orders>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<Orders>(obj);

            var result = DataAccessFactory.OrderData().Create(data);
            var redata = mapper.Map<OrdersDTO>(result);
            return redata;
        }
        public static OrdersDTO Delete(int Id)
        {
            var data = DataAccessFactory.OrderData().Delete(Id);

            return null;

        }
        public static OrdersDTO Update(OrdersDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Orders, OrdersDTO>();
                c.CreateMap<OrdersDTO, Orders>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<Orders>(obj);
            var result = DataAccessFactory.OrderData().Update(data);
            var redata = mapper.Map<OrdersDTO>(result);
            return redata;

        }
    }
}
