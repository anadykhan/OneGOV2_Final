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
    public class CategoryService
    {
        public static List<CategoriesDTO> Get()
        {
            var data = DataAccessFactory.CategoriesData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Categories, CategoriesDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<CategoriesDTO>>(data);
            return mapped;
        }
        public static CategoriesDTO Get(int id)
        {
            var data = DataAccessFactory.CategoriesData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Categories, CategoriesDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<CategoriesDTO>(data);
            return mapped;
        }
        public static CategoriesDTO Create(CategoriesDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Categories, CategoriesDTO>();
                c.CreateMap<CategoriesDTO, Categories>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<Categories>(obj);

            var result = DataAccessFactory.CategoriesData().Create(data);
            var redata = mapper.Map<CategoriesDTO>(result);
            return redata;
        }
        public static CategoriesDTO Delete(int Id)
        {
            var data = DataAccessFactory.CategoriesData().Delete(Id);

            return null;



        }
        public static CategoriesDTO Update(CategoriesDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Categories, CategoriesDTO>();
                c.CreateMap<CategoriesDTO, Categories>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<Categories>(obj);
            var result = DataAccessFactory.CategoriesData().Update(data);
            var redata = mapper.Map<CategoriesDTO>(result);
            return redata;

        }
    }
}
