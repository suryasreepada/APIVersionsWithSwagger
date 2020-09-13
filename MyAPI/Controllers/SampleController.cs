using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyAPI.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace MyAPI.Controllers
{
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    [ApiController]
    [Route("v{version:apiVersion}")]
    public class SampleController : ControllerBase
    {
        public SampleController()
        {
            
        }

        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(UserModel))]
        [HttpGet]
        [MapToApiVersion("1.0")]
        [Route("GetUser")]
        public ActionResult<UserModel> GetUserV1()
        {
            return Ok(new UserModel 
            {
                Name = "UserName",
                UserId = "v1"
            });
        }

        [HttpGet]
        [MapToApiVersion("2.0")]
        [Route("GetUser")]
        public ActionResult<UserModelV2> GetUserV2()
        {
            return Ok(new UserModelV2
            {
                Name = "UserName",
                UserId = "v2",
                StartDate = DateTime.Now
            });
        }
    }
}
