using System.Globalization;
namespace Course {

    internal class Program {
        static void Main(string[] args) {
            Funcionario func1 = new Funcionario();
            Console.WriteLine("Nome:");
            func1.Nome = Console.ReadLine();

            Console.WriteLine("Salário Bruto: ");
            func1.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Imposto: ");
            func1.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Funcionário: " + func1);

            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            double Porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            func1.AumentarSalario(Porcentagem);

            Console.WriteLine( "Dados Atualizados: " + func1 );

        }


    }
}