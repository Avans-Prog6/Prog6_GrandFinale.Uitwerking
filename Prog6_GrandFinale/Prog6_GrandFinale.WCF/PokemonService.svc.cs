using Prog6_GrandFinale.WCF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Prog6_GrandFinale.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class PokemonService : IPokemonService
    {
        public PokemonService()
        {

        }

        public Pokemon CreatePokemons(Pokemon pokemon)
        {
            using(var context = new PokemonContext())
            {
                context.Pokemons.Add(pokemon.ToPoco());
                context.SaveChanges();
                return pokemon;
            }
            
        }

        public IEnumerable<Pokemon> GetPokemons()
        {
            using (var context = new PokemonContext())
            {
                var pokemons = context.Pokemons.ToList();
                return pokemons.Select(p => new Pokemon(p));
            }
        }
    }
}
