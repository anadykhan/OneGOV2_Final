﻿using AutoMapper;
using BusinessLogicLayer.DTOs;
using DataAccessLayer.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer.Services
{
    public class UserService
    {
        public static List<UserDTO> Get()
        {
            var data = DataAccessFactory.UserData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<User, UserDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<UserDTO>>(data);
            return mapped;
        }
        public static UserDTO Get(string id)
        {
            var data = DataAccessFactory.UserData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<User, UserDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<UserDTO>(data);
            return mapped;
        }
        public static UserDTO Create(UserDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<User, UserDTO>();
                c.CreateMap<UserDTO, User>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<User>(obj);

            var result = DataAccessFactory.UserData().Create(data);
            var redata = mapper.Map<UserDTO>(result);
            return redata;
        }
        public static UserDTO Delete(string Id)
        {
            var data = DataAccessFactory.UserData().Delete(Id);

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<User, UserDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<UserDTO>(data);
            return mapped;
        }
        public static UserDTO Update(UserDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<User, UserDTO>();
                c.CreateMap<UserDTO, User>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<User>(obj);
            var result = DataAccessFactory.UserData().Update(data);
            var redata = mapper.Map<UserDTO>(result);
            return redata;

        }
    }
}
