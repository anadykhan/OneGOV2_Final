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
    public class UserOrderController : ApiController
    {
        [HttpGet]
        [Route("api/userorder")]
        public HttpResponseMessage UserOrder()
        {
            try
            {
                var data = UserOrderService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }

        }
        [HttpGet]
        [Route("api/userorder/{id}")]
        public HttpResponseMessage UserOrder(int Id)
        {
            try
            {
                var data = UserOrderService.Get(Id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/userorder/create")]
        public HttpResponseMessage Create(UserOrderDTO data)
        {
            try
            {
                var data1 = UserOrderService.Create(data);
                return Request.CreateResponse(HttpStatusCode.OK, data1);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

       

        [HttpDelete]
        [Route("api/userorder/delete/{id}")]
        public HttpResponseMessage Delete(int Id)
        {
            var exm = UserOrderService.Get(Id);
            if (exm != null)
            {
                try
                {
                    var data = UserOrderService.Delete(Id);
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
        [HttpPost]
        [Route("api/userorder/update")]
        public HttpResponseMessage Update(UserOrderDTO data)
        {
            var exm = UserOrderService.Get(data.ID);
            if (exm != null)
            {
                try
                {
                    var data1 = UserOrderService.Update(data);
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
    }
}
