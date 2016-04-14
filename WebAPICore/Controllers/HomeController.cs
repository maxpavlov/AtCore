using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using WebAPICore.Core;

namespace WebAPICore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBusinessValueProvider _businessValueProvider;

        public HomeController(IBusinessValueProvider businessValueProvider)
        {
            _businessValueProvider = businessValueProvider;
        }

        public IActionResult Index()
        {
            return View("Index", _businessValueProvider.ProvideValue());
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
