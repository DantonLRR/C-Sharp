using System.Globalization;
namespace Course {

    internal class Program {
        static void Main(string[] args) {
            Console.Write("Qual é a cotação do dólar?");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos Dólares você vai comprar?");
            double qntDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor pago em reais: "+ calculadora.ConversorDeMoeda(cotacao, qntDolar).ToString("F2"),CultureInfo.InvariantCulture);
        }


    }
}