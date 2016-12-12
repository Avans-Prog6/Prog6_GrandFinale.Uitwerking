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

        [Required]
        [MinLength(2)]
        [MaxLength(30)]
        public string Name { get; set; }
        
        [Required]
        [MinLength(2)]
        [MaxLength(30)]
        public string Type { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [Range(0, 30)]
        public int Level { get; set; }
    }
}