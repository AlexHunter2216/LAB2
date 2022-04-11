using System;

namespace Laboratorio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta_Corrente Cliente1 = new Conta_Corrente("12345-6", "Bob Nelson");
            Conta_Poupança Cliente2 = new Conta_Poupança("71717-1", "Testolfo Rocha");
            Conta_Corrente Cliente3 = new Conta_Corrente("65432-1", "Lisa Leite");

            Cliente1.DepositarDinheiro(5000);
            Cliente3.DepositarDinheiro(2000);
            Cliente2.DepositarDinheiro(1500);
            Console.WriteLine(Cliente1.TransferirDinheiro(600,Cliente2));
            Console.WriteLine(Cliente3.DebitarValorSaque(250));
            Console.WriteLine(Cliente3.TransferirDinheiro(400, Cliente2));
            Console.WriteLine(Cliente2.TransferirDinheiro(1000, Cliente1));
            Console.WriteLine(Cliente1.DebitarValorSaque(900));
            Console.WriteLine(Cliente1.TransferirDinheiro(1500, Cliente3));
            Console.WriteLine(Cliente2.TransferirDinheiro(1200, Cliente3));
            Console.WriteLine(Cliente1.DebitarValorSaque(2000));
            Cliente3.DepositarDinheiro(100);
            Console.WriteLine(Cliente2.TransferirDinheiro(700, Cliente1));
            Console.WriteLine(Cliente1.VerificarSaldo());
            Console.WriteLine(Cliente2.VerificarSaldo());
            Console.WriteLine(Cliente3.VerificarSaldo());

            //apenas um teste para saber se a transferencia estava funcionando. 
            Console.WriteLine(Cliente1.TransferirDinheiro(50,Cliente2));
            Console.WriteLine(Cliente1.VerificarSaldo());
            Console.WriteLine(Cliente2.VerificarSaldo());
            Console.ReadLine();

        }
    }
}
