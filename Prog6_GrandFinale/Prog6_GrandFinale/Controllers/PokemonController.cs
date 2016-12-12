using Prog6_GrandFinale.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prog6_GrandFinale.Controllers
{
    public class PokemonController : Controller
    {
        // GET: Pokemon
        public ActionResult Index()
        {
            var pokemons = new List<Pokemon>();
            pokemons.Add(new Pokemon() { Name = "Pikachu", Level = 30 });
            return View(pokemons);
        }

        public ActionResult Create()
        {
            var pokemon = new Pokemon();
            return View(pokemon);
        }

        [HttpPost]
        public ActionResult Create(Pokemon pokemon)
        {
            //nu nog niks.
            return RedirectToAction("Index");
        }
    }
}