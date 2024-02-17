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
    public class RoomService
    {
        public static List<RoomDTO> Get()
        {
            var data = DataAccessFactory.RoomData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Room, RoomDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<RoomDTO>>(data);
            return mapped;
        }

        public static RoomDTO GetById(int id)
        {
            var data = DataAccessFactory.RoomData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Room, RoomDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<RoomDTO>(data);
            return mapped;
        }

        public static RoomDTO Create(RoomDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Room, RoomDTO>();
                c.CreateMap<RoomDTO, Room>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<Room>(obj);

            var result = DataAccessFactory.RoomData().Create(data);
            var redata = mapper.Map<RoomDTO>(result);
            return redata;
        }

        public static RoomDTO Update(RoomDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Room, RoomDTO>();
                c.CreateMap<RoomDTO, Room>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<Room>(obj);
            var result = DataAccessFactory.RoomData().Update(data);
            var redata = mapper.Map<RoomDTO>(result);
            return redata;

        }
    }
}