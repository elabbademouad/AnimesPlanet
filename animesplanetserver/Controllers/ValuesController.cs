using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace animesplanetserver.Controllers
{
    //[Route("api/[controller]")]
    public class ValuesController : Controller
    {       
        [HttpGet]
        public string Index()
        {
            return "Hello animes fun  from Server side !";
        }
    }
}
