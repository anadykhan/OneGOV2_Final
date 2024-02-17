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
    public class CartController : ApiController
    {
        [HttpGet]
        [Route("api/cart")]
        public HttpResponseMessage Like()
        {
            try
            {
                var data = CartService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }

        }
        [HttpGet]
        [Route("api/cart/{id}")]
        public HttpResponseMessage Like(int Id)
        {
            try
            {
                var data = CartService.GetById(Id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/cart/create")]
        public HttpResponseMessage Create(CartDTO data)
        {
            try
            {
                var data1 = CartService.Create(data);
                return Request.CreateResponse(HttpStatusCode.OK, data1);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/cart/update")]
        public HttpResponseMessage Update(CartDTO data)
        {
            var exm = CartService.GetById(data.CartID);
            if (exm != null)
            {
                try
                {
                    var data1 = CartService.Update(data);
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
        [Route("api/cart/delete/{id}")]
        public HttpResponseMessage Delete(int Id)
        {
            var exm = CartService.GetById(Id);
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
                var data = CartService.GetById(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
    }
}
