using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Prog6_GrandFinale.WCF.Data
{
    public class PokemonContext : DbContext
    {
        public PokemonContext() : base("name=default")
        {

        }

        public DbSet<Domain.Pokemon> Pokemons { get; set; }

    }
}