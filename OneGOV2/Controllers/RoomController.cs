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
    public class RoomController : ApiController
    {
        [HttpGet]
        [Route("api/rooms")]
        public HttpResponseMessage Rooms()
        {
            try
            {
                var data = RoomService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { message = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/rooms/{id}")]
        public HttpResponseMessage Rooms(int Id)
        {
            try
            {
                var data = RoomService.GetById(Id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/rooms/create")]
        public HttpResponseMessage Create(RoomDTO data)
        {
            try
            {
                var data1 = RoomService.Create(data);
                return Request.CreateResponse(HttpStatusCode.OK, data1);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/rooms/update")]
        public HttpResponseMessage Update(RoomDTO data)
        {
            var exm = RoomService.GetById(data.RoomID);
            if (exm != null)
            {
                try
                {
                    var data1 = RoomService.Update(data);
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