using BusinessLogicLayer.DTOs;
using BusinessLogicLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Services.Description;

namespace OneGOV2.Controllers
{
    public class HotelController : ApiController
    {
        [HttpGet]
        [Route("api/hotel/all")]
        public HttpResponseMessage Hotels()
        {
            try
            {
                var data = HotelService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/hotel/{id}")]
        public HttpResponseMessage Hotels(int Id)
        {
            try
            {
                var data = HotelService.Get(Id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/hotel/create")]
        public HttpResponseMessage Create(HotelDTO data)
        {
            try
            {
                var data1 = HotelService.Create(data);
                return Request.CreateResponse(HttpStatusCode.OK, data1);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpPut]
        [Route("api/hotel/update")]
        public HttpResponseMessage Update(HotelDTO data)
        {
            var exm = HotelService.Get(data.HotelID);
            if (exm != null)
            {
                try
                {
                    var data1 = HotelService.Update(data);
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
        [Route("api/hotel/delete/{id}")]
        public HttpResponseMessage Delete(int Id)
        {
            var exm = HotelService.Get(Id);
            if (exm != null)
            {
                try
                {
                    var data = HotelService.Delete(Id);
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