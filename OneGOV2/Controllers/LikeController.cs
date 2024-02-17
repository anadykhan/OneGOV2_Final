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
    public class LikeController : ApiController
    {
        [HttpGet]
        [Route("api/like")]
        public HttpResponseMessage Like()
        {
            try
            {
                var data = LikeService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }

        }
        [HttpGet]
        [Route("api/like/{id}")]
        public HttpResponseMessage Like(int Id)
        {
            try
            {
                var data = LikeService.GetById(Id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/like/create")]
        public HttpResponseMessage Create(LikeDTO data)
        {
            try
            {
                var data1 = LikeService.Create(data);
                return Request.CreateResponse(HttpStatusCode.OK, data1);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/like/update")]
        public HttpResponseMessage Update(BlogDTO data)
        {
            var exm = LikeService.GetById(data.Id);
            if (exm != null)
            {
                try
                {
                    var data1 = BlogService.Update(data);
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
        [Route("api/like/delete/{id}")]
        public HttpResponseMessage Delete(int Id)
        {
            var exm = LikeService.GetById(Id);
            if (exm != null)
            {
                try
                {
                    var data = LikeService.Delete(Id);
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

        [HttpGet]
        [Route("api/like/{id}/comments")]
        public HttpResponseMessage PostComment(int id)
        {
            try
            {
                var data = LikeService.GetById(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
    }
}
