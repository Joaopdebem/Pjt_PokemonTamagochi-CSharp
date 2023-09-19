using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemagochi.Pokemons
{
    public class Mascote
    {
        public List<Abilities> Habilidades { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }
        public string Nome { get; set; }
        public int Alimentacao { get; set; }
        public int Humor { get; set; }
        public DateTime DataNascimento { get; set; }

        public Mascote()
        {
            Random valorRandomic = new Random();
            Alimentacao = valorRandomic.Next(2, 10);
            Humor = valorRandomic.Next(2, 10);
            DataNascimento = DateTime.Now;
        }

        public bool VerificarFome()
        {
            return this.Alimentacao < 5;
        }
        public void AlimentarMascote()
        {
            this.Alimentacao++;
        }
        public void BrincarMascote()
        {
            this.Humor++;
            this.Alimentacao--;
        }
        public bool SaudeMascote()
        {
            return (this.Alimentacao > 0 && this.Humor > 0);
        }

    }
}
