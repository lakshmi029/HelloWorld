using AttributeRouting;
using HelloWorldWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace HelloWorldWebAPI.Controllers
{
    [RoutePrefix("api/Home/Index")]
    public class HomeController : ApiController
    {
        [HttpGet]
        public async Task<HttpResponseMessage> Get()
        {
            HelloWorldModel model = new HelloWorldModel();
            model.ReturnValue = ConfigurationManager.AppSettings["ReturnValueText"];
            return Request.CreateResponse(HttpStatusCode.OK, model.ReturnValue);
        }
    }
}
