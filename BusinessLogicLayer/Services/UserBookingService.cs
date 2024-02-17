using AutoMapper;
using BusinessLogicLayer.DTOs;
using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class UserBookingService
    {
        public static List<UserBookingDTO> Get()
        {
            var data = DataAccessFactory.UserBookingData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<UserBooking, UserBookingDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<UserBookingDTO>>(data);
            return mapped;
        }

        public static UserBookingDTO GetById(int id)
        {
            var data = DataAccessFactory.UserBookingData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<UserBooking, UserBookingDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<UserBookingDTO>(data);
            return mapped;
        }

        public static UserBookingDTO Create(UserBookingDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<UserBooking, UserBookingDTO>();
                c.CreateMap<UserBookingDTO, UserBooking>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<UserBooking>(obj);

            var result = DataAccessFactory.UserBookingData().Create(data);
            var redata = mapper.Map<UserBookingDTO>(result);
            return redata;
        }
    }
}