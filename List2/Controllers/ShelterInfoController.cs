using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using List2.Models;

namespace List2.Controllers
{
    public class ShelterInfoController : Controller
    {
        // GET: ShelterInfo
        public ActionResult Index()
        {
            var dogs = new List<Dogs>()
            {
                new Dogs {name = "Louie", breed = "Dalmation", age = 5, size = "Large", dogID = 496},
                new Dogs {name = "Buddy", breed = "Golden Retriever", age = 2, size = "Large", dogID = 565},
                new Dogs {name = "Rocky", breed = "Toy Poodle", age = 13, size = "Small", dogID = 801}
            };
            var cats = new List<Cats>()
            {
                new Cats {name = "springles", breed = "Bengal cat", age = 3, size = "Small", catID = 123},
                new Cats {name = "Garfield", breed = "Persian cat", age = 5, size = "Large",catID = 656},
                new Cats {name = "Bandit", breed = "American Bobtail", age = 4, size = "Large", catID = 343}
            };

            var shelters = new shelters
            {
                Dogs = dogs,
                Cats = cats
            };

            return View(shelters);
        }
    }
}