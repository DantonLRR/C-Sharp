using System.Globalization;
namespace Course {

    internal class Program {
        static void Main(string[] args) {
            ContaBancaria ContaBancaria;

            Console.Write("Digite o Numero da Conta:");
            int conta = int.Parse(Console.ReadLine());

            Console.Write("Digite o Nome do titular da Conta: ");
            string titular = Console.ReadLine();

            Console.Write("Deseja fazer depósito inicial?(s/n)");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's'|| resp == 'S') {
                Console.Write("Entre o valor do Depósito inicial: ");
                double depInicial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                ContaBancaria = new ContaBancaria(conta, titular,depInicial);
            }
            else {
                ContaBancaria = new ContaBancaria(conta, titular);
            }

                Console.Write(ContaBancaria);
            Console.WriteLine();
           Console.WriteLine("Digite o valor que será depositado: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ContaBancaria.Deposito(deposito);
            Console.WriteLine();
            Console.Write("Dados da Conta Atualizados:");
            Console.Write(ContaBancaria);
            Console.WriteLine();
            Console.Write("Digite o valor do saque:");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ContaBancaria.Saque(saque);
            Console.WriteLine("Dados da Conta Atualizados:");
            Console.Write(ContaBancaria);
        }


    }
}