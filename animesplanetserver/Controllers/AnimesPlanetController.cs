using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using animesplanetserver.Model;
using animesplanetserver.DataService.DataContext;

namespace animesplanetserver.Controllers
{
    //[Route("api/[controller]")]
    public class AnimesPlanetController : Controller
    {       
        [HttpGet]
        public List<Anime> Index()
        {
             List<Anime> list=null;
            using (AnimesPlanetDataContext db=new AnimesPlanetDataContext() )
            {
                list=db.Animes.ToList();
            }
            return list;
        }
    }
}
