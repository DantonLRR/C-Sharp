using System.Globalization;
namespace Course {

    internal class Program {
        static void Main(string[] args) {
            retangulo Retangulo = new retangulo();
          


            Console.WriteLine("Entre a largura e a altura do retângulo");
            Retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(Retangulo);


        }


    }
}