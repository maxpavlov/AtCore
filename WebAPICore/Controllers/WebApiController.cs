using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using WebAPICore.Core;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPICore.Controllers
{
    [Route("api/businessvalue")]
    public class WebApiController : Controller
    {
        private readonly IBusinessValueProvider _businessValueProvider;

        public WebApiController(IBusinessValueProvider businessValueProvider)
        {
            _businessValueProvider = businessValueProvider;
        }

        [HttpGet]
        public string Get()
        {
            return _businessValueProvider.ProvideValue();
        }
    }
}
