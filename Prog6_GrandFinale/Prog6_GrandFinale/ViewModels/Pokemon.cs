using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Prog6_GrandFinale.PokemonService;

namespace Prog6_GrandFinale.ViewModels
{
    public class Pokemon
    {
        private PokemonService.Pokemon p;

        public Pokemon(PokemonService.Pokemon p)
        {
            Name = p.Name;
            DateOfBirth = p.DateOfBirth;
            Type = p.Type;
            Level = p.Level;
        }

        public Pokemon()
        {
        }

        public string Name { get; set; }

        public string Type { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        public int Level { get; set; }
    }
}