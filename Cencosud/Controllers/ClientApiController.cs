using Cencosud.Models;
using Cencosud.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Cencosud.Controllers
{
    [RoutePrefix("api/clients")]
    public class ClientApiController : ApiController
    {
        private IClientService IClientService;
        public ClientApiController(IClientService IClientService)
        {
            this.IClientService = IClientService;
        }

        [HttpGet]
        [Route("")]
        public IHttpActionResult FirstCall()
        {
            var obj = this.IClientService.firstCall();
            if (obj == null)
            {
                return NotFound();
            }
            return Ok(obj);
        }
    }
}
