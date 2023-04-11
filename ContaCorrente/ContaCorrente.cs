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
        public int quantia;
        public string msgEspecial;
        public Movimentacao[] movimentacao;

        public int PosicaoVazia()
        {
            int vazio = 0;
            for (int i = 0; i < this.movimentacao.Length; i++)
            {
                if (this.movimentacao[i] == null)
                {
                    vazio = i;
                }
            }

            return vazio;
        }
        public string MensagemEspecial()
        {
            if (this.ehEspecial == true) //Altera a mensagem de é especial na função VerExtrato para que não moster True/False
                msgEspecial += "Sim.";
            else
                msgEspecial += "Não.";

            return msgEspecial;
        }
        public void SacarValor(int quantia)
        {
            if(quantia < this.limite + this.saldo)
            {
                this.saldo -= quantia;

                Movimentacao mx = new Movimentacao();
                mx.valor = quantia;
                mx.tipo = "DÉBITO";
                mx.descricao = $"Saque de R${quantia}.";
                this.movimentacao[PosicaoVazia()] = mx;
            }
        }        
        public void DepositarValor(int quantia)
        {
            this.saldo += quantia;
            
            Movimentacao mx = new Movimentacao();
            mx.valor = quantia;
            mx.tipo = "CRÉDITO";
            mx.descricao = $"Depósito de R${quantia}.";
            this.movimentacao[PosicaoVazia()] = mx;

        }
        public void VerSaldo(int saldo)
        {
            Console.WriteLine($"Seu saldo é:R${this.saldo}");
        }
        public void VerExtrato()
        {
            Console.Title = $"Banco do Caio - Extrato da Conta {this.numero}";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"------------------------------");
            Console.WriteLine($"           CONTA {this.numero}           ");
            Console.WriteLine($"------------------------------");
            Console.WriteLine($"Número: {this.numero}");
            Console.WriteLine($"Saldo: R${this.saldo}");
            Console.WriteLine($"Limite: R${this.limite}");
            Console.WriteLine($"É conta especial: {this.MensagemEspecial()}");
            Console.WriteLine($"------------------------------");
            Console.WriteLine($"        MOVIMENTAÇÕES        ");
            Console.WriteLine($"------------------------------");
            Console.ResetColor();
            for (int i = 0; i < movimentacao.Length; i++) 
            { 
                if (this.movimentacao[i] != null)
                {
                    this.movimentacao[i].ShowDescricao();
                }
            }
            Console.WriteLine($"------------------------------", Console.ForegroundColor = ConsoleColor.Cyan);
        }
        public void FazerTransferencia(ContaCorrente conta2, int quantia)
        {
            this.SacarValor(quantia);
            conta2.DepositarValor(quantia);
        }
    }
}
