using AutoMapper;
using BusinessLogicLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataAccessLayer.Models;


namespace BusinessLogicLayer.Services
{
    public class ProductService
    {
        public static List<ProductsDTO> Get()
        {
            var data = DataAccessFactory.ProductData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Products, ProductsDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<ProductsDTO>>(data);
            return mapped;
        }
        public static ProductsDTO Get(string id)
        {
            var data = DataAccessFactory.ProductData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Products, ProductsDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ProductsDTO>(data);
            return mapped;
        }
        public static ProductsDTO Create(ProductsDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Products, ProductsDTO>();
                c.CreateMap<ProductsDTO, Products>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<Products>(obj);

            var result = DataAccessFactory.ProductData().Create(data);
            var redata = mapper.Map<ProductsDTO>(result);
            return redata;
        }
        public static ProductsDTO Delete(string Id)
        {
            var data = DataAccessFactory.ProductData().Delete(Id);

            return null;



        }
        public static ProductsDTO Update(ProductsDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Products, ProductsDTO>();
                c.CreateMap<ProductsDTO, Products>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<Products>(obj);
            var result = DataAccessFactory.ProductData().Update(data);
            var redata = mapper.Map<ProductsDTO>(result);
            return redata;

        }
    }
}
