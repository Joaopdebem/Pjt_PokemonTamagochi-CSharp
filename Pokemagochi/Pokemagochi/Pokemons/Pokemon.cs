using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemagochi.Pokemons
{
    public class Pokemon
    {
        public List<Abilities> abilities { get; set; }
        public double height { get; set; }
        public double weight { get; set; }
        public string name { get; set; }
    }
}
