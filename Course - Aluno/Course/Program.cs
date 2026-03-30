using System.Globalization;
namespace Course {

    internal class Program {
        static void Main(string[] args) {
            Aluno aluno1 = new Aluno();
            Console.WriteLine("Nome do aluno: ");
      
            aluno1.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            aluno1.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno1.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno1.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(aluno1.notaFinal()); 

        }


    }
}