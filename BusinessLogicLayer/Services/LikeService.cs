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
    public class LikeService
    {
        public static List<LikeDTO> Get()
        {
            var data = DataAccessFactory.LikeData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Like, LikeDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<LikeDTO>>(data);
            return mapped;
        }

        public static LikeDTO GetById(int id)
        {
            var data = DataAccessFactory.LikeData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Like, LikeDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<LikeDTO>(data);
            return mapped;
        }

        public static LikeDTO Create(LikeDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Like, LikeDTO>();
                c.CreateMap<LikeDTO, Like>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<Like>(obj);

            var result = DataAccessFactory.LikeData().Create(data);
            var redata = mapper.Map<LikeDTO>(result);
            return redata;
        }

        public static LikeDTO Update(LikeDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Like, LikeDTO>();
                c.CreateMap<LikeDTO, Like>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<Like>(obj);
            var result = DataAccessFactory.LikeData().Update(data);
            var redata = mapper.Map<LikeDTO>(result);
            return redata;

        }

        public static LikeDTO Delete(int Id)
        {
            var data = DataAccessFactory.LikeData().Delete(Id);

            return null;

        }
    }
}