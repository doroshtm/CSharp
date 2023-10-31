using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _3Bimestre.ONG_Animal
{

    internal class Animal : SerVivo
    {
        public string Genero { get; set; }

        public Boolean DisponibilidadeAdocao { get; set; }
        public string Tipo { get; set; }

        public string Vacinacao { get; set; }

        public string Status { get; set; }
        public Animal()
        {
        }
        override public Dictionary<string,dynamic> EnviarTodasInformacoes()
        {
            Dictionary<string, dynamic> output = new Dictionary<string, dynamic>
            {
                {"id", this.Id },
                {"nome", this.Nome},
                {"data", this.Data_Nascimento},
                {"tipo", this.Tipo },
                {"genero", this.Genero},
                {"status", this.Status},
                {"vacinacao", this.Vacinacao },
                {"disponibilidade", this.DisponibilidadeAdocao}
            };
            return output;

        }
    }
}
