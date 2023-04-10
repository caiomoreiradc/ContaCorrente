using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente
{
    internal class ContaCorrente
    {
        //CONTAS
        public int numero;
        public int saldo;
        public int limite;
        public bool ehEspecial = false;
        //FUNÇÕES
        public int valorSaque;
        public int valorDeposito;
        public int valorTransferencia;

        public void SacarValor(int valorSaque)
        {
            if(valorSaque> saldo)
            {
                Console.WriteLine("Operação inválida");
                saldo = saldo;
            }            
            else if(valorSaque > limite)
            {
                Console.WriteLine("Operação inválida! Sem Limite!");
                saldo = saldo;
            }
            else 
            { 
            saldo -= valorSaque;
            Console.WriteLine($"Após o saque de R${valorSaque} o seu saldo é de R${saldo}", ConsoleColor.Red);
            }
        }        

        public void DepositarValor(int valorDeposito)
        {
            saldo += valorDeposito;
            Console.WriteLine($"Com um depósito de R${valorDeposito} seu saldo agora é R${saldo}", ConsoleColor.Green);
        }

        public void FazerTransferencia(ContaCorrente conta2, int valorTransferencia)
        {
            if (conta2 == this)
            {
                Console.WriteLine("Não pode transferir para sua própria conta", ConsoleColor.Red);
            }

            else if (saldo < valorTransferencia)
            {
                Console.WriteLine("Saldo insuficiente!", ConsoleColor.Red);
            }

            else
            {
                saldo -= valorTransferencia;
                conta2.saldo += valorTransferencia;
                Console.WriteLine($"Transferencia realizada no valor de R${valorTransferencia} para a conta {conta2}");
            }
        }

    }
}
