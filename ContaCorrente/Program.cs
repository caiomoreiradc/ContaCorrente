namespace ContaCorrente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta1 = new ContaCorrente();
            conta1.numero = 12;
            conta1.saldo = 1000;
            conta1.limite = 0;
            conta1.ehEspecial = true;
            conta1.movimentacao = new Movimentacao[10];

            conta1.SacarValor(200);

            conta1.DepositarValor(300);

            conta1.DepositarValor(500);

            conta1.SacarValor(200);

            ContaCorrente conta2 = new ContaCorrente();
            conta2.saldo = 5000;
            conta2.numero = 29;
            conta2.limite = 0;
            conta2.ehEspecial = true;
            conta2.movimentacao = new Movimentacao[10];


            conta1.FazerTransferencia(conta2, 400);
            conta1.VerExtrato();
            Console.ReadKey();
        }
    }
}