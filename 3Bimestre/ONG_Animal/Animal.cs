using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Bimestre.ONG_Animal
{
    internal class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Genre { get; set; }
        public string Vaccine { get; set; }
        public string Type { get; set; }
        public DateTime BirthDate { get; set; }
        public Boolean Adoptable { get; set; }

        public Animal() 
        {

        }

    }
}
