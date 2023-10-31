using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Bimestre.ONG_Animal
{
    public abstract class SerVivo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Data_Nascimento { get; set; }

        abstract public Dictionary<string, dynamic> EnviarTodasInformacoes();
    }
}
