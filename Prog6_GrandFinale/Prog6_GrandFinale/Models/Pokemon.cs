using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prog6_GrandFinale.Models
{
    public class Pokemon
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int Level { get; set; }
    }
}