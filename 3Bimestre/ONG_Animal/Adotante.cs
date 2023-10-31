using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Bimestre.ONG_Animal
{
    public class Adotante : SerVivo
    {
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }


        public Adotante() { 
        }

        override public Dictionary<string, dynamic> EnviarTodasInformacoes()
        {
            Dictionary<string, dynamic> output = new Dictionary<string, dynamic>()
            {
                {"id", this.Id },
                {"nome", this.Nome},
                {"data", this.Data_Nascimento},
                {"rg", this.Rg},
                {"cpf", this.Cpf},
                {"endereco", this.Endereco },
                {"cidade", this.Cidade},
                {"estado", this.Estado },
                {"telefone",this.Telefone }
            };
            return output;
                
        }
    }
}
