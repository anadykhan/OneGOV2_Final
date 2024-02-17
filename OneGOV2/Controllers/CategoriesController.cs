using BusinessLogicLayer.DTOs;
using BusinessLogicLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OneGOV2.Controllers
{
    public class CategoriesController : ApiController
    {
        [HttpGet]
        [Route("api/Category")]
        public HttpResponseMessage Category()
        {
            try
            {
                var data = CategoryService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }

        }
        [HttpGet]
        [Route("api/Category/{id}")]
        public HttpResponseMessage Category(int Id)
        {
            try
            {
                var data = CategoryService.Get(Id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/Category/create")]
        public HttpResponseMessage Create(CategoriesDTO data)
        {
            try
            {
                var data1 = CategoryService.Create(data);
                return Request.CreateResponse(HttpStatusCode.OK, data1);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/Category/update")]
        public HttpResponseMessage Update(CategoriesDTO data)
        {
            var exm = CategoryService.Get(data.CategoriID);
            if (exm != null)
            {
                try
                {
                    var data1 = CategoryService.Update(data);
                    return Request.CreateResponse(HttpStatusCode.OK, data1);
                }
                catch (Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
                }
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Not Found");
            }
        }

        [HttpDelete]
        [Route("api/Category/delete/{id}")]
        public HttpResponseMessage Delete(int Id)
        {
            var exm = CategoryService.Get(Id);
            if (exm != null)
            {
                try
                {
                    var data = CategoryService.Delete(Id);
                    return Request.CreateResponse(HttpStatusCode.OK, "Deleted");
                }
                catch (Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
                }
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Not Found");
            }
        }
    }
}
