namespace ContaCorrente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta1 = new ContaCorrente();
            conta1.saldo = 2000;
            conta1.numero = 21;
            conta1.limite = 0;
            conta1.ehEspecial = true;

            conta1.SacarValor(500);

            conta1.DepositarValor(200);

            conta1.DepositarValor(300);

            conta1.SacarValor(100);

            ContaCorrente conta2 = new ContaCorrente();
            conta2.saldo = 5000;
            conta2.numero = 29;
            conta2.limite = 0;
            conta2.ehEspecial = true;

         



        }
    }
}