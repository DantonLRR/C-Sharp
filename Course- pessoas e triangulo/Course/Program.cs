using System.Globalization;
namespace Course {

    internal class Program {
        static void Main(string[] args) {
            Pessoas Pessoa1, Pessoa2;
            Pessoa1 = new Pessoas();
            Pessoa2 = new Pessoas();

            Console.WriteLine("Dados da primeira pessoa");
            Pessoa1.Nome = Console.ReadLine();
            Pessoa1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa");
            Pessoa2.Nome = Console.ReadLine();
            Pessoa2.idade = int.Parse(Console.ReadLine());

            if (Pessoa1.idade > Pessoa2.idade) {
                Console.WriteLine("Pessoa mais velha {0}", Pessoa1.Nome);
            }
            else {
                Console.WriteLine("Pessoa mais velha {0}", Pessoa2.Nome);
            }
            Console.WriteLine("-------------------------------------------------");

            Funcionarios Funcionario1, Funcionario2;
            Funcionario1 = new Funcionarios();
            Funcionario2 = new Funcionarios();

            Console.WriteLine("Dados do primeiro funcionario");
            Funcionario1.Nome = Console.ReadLine();
            Funcionario1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Dados do segundo funcionario");
            Funcionario2.Nome = Console.ReadLine();
            Funcionario2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double media = (Funcionario1.salario + Funcionario2.salario) / 2.0;
            Console.WriteLine("Média de salarios {0}", media.ToString("F2", CultureInfo.InvariantCulture));
        }


    }
}