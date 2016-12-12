using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prog6_GrandFinale.Models
{
    public class Pokemon
    {
        public string Name { get; set; }

        public string Type { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        public int Level { get; set; }
    }
}