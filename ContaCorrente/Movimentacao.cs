using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente
{
    internal class Movimentacao
    {
        public int valor;
        public string tipo;
        public string descricao;

        public void ShowDescricao()
        {
            if(tipo == "DÉBITO")
            Console.WriteLine($"-{tipo} = {descricao}",Console.ForegroundColor = ConsoleColor.Red);
            else
            Console.WriteLine($"+{tipo} = {descricao}",Console.ForegroundColor = ConsoleColor.Green);
        }


    }
}
