using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ProgramcaoobjetoC.models
{
    public class ContaCorrente
    {
        public ContaCorrente ( int numeroConta, decimal SaldoInicial)
        {
            NumeroConta= numeroConta;
            Saldo=SaldoInicial;
        }
        public int NumeroConta { get; set; }
        private decimal Saldo;
        // scar é um maneira de entrar no meu encapsulamento privado 
        public void Sacar (decimal valor)
        {
            if(Saldo <= valor)
            {
                Saldo-= valor;
                Console.WriteLine("Saque Realizado com sucesso");
            }
            else{
                Console.WriteLine("Saque informado é mairo que o valor disponivel");
            }

        }
        public void ExibirSaldo(){
            Console.WriteLine("Seu Saldo disponivel é "+Saldo);
        }
    }
}