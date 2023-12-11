using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramcaoobjetoC.models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresenta()
        {
            Console.WriteLine($"Olá, menu nome é {Nome} idade {Idade}");
        }
    }
}