using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using p_p_v2.Models;

namespace p_p_v2.Controllers
{
    public class SetColorController : Controller
    {
        private readonly ILogger<SetColorController> _logger;

        public SetColorController(ILogger<SetColorController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string color)
        {
            Console.WriteLine("colo r");
            Console.WriteLine(color);
            Response.Cookies.Append("bkcolor", color);  
            return new OkResult();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
