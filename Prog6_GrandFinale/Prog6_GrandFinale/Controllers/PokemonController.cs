using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prog6_GrandFinale.Controllers
{
    public class PokemonController : Controller
    {
        private PokemonService.IPokemonService _service;

        public PokemonController()
        {
            //kan dit slimmer?
            this._service = new PokemonService.PokemonServiceClient("BasicHttpBinding_IPokemonService");
        }


        // GET: Pokemon
        public ActionResult Index()
        {
            List<ViewModels.Pokemon> pokemons = _service.GetPokemons()
                .Select(p => new ViewModels.Pokemon(p))
                .ToList();

            return View(pokemons);
        }

        public ActionResult Create()
        {
            var pokemon = new ViewModels.Pokemon();
            return View(pokemon);
        }

        [HttpPost]
        public ActionResult Create(ViewModels.Pokemon pokemon)
        {
            //Dit stond per ongeluk al in de controller!
            if (!ModelState.IsValid)
            {
                return View(pokemon);
            }

            PokemonService.Pokemon data = new PokemonService.Pokemon()
            {
                Name = pokemon.Name,
                DateOfBirth = pokemon.DateOfBirth,
                Type = pokemon.Type,
                Level = pokemon.Level
            };

            _service.CreatePokemons(data);
            return RedirectToAction("Index");
        }
    }
}