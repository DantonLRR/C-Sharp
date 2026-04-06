using System.Globalization;
namespace Course {

    internal class Program {
        static void Main(string[] args) {
            Console.Write("Digite a o tamanho da matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];
            int[] negativo = new int[10];
            int contNegativo = 0;
            Console.WriteLine("Digite os valores ");
            for (int i = 0; i < n; i++) {
                //roda 1 vez depois de rodar todas vezes do j
                for (int j = 0; j < n; j++) {
                    Console.Write("Valor #" + i +", "+ j+": ");
                    int aux = int.Parse(Console.ReadLine());
                 
                    matriz[i, j] = aux;
                    if (aux < 0) {
                        contNegativo++;
                    }
                }
            }

            Console.Write( "Main diagonal:" );
            for(int i = 0; i<n; i++) {
                        Console.Write(matriz[i,i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Negative numbers = "+ contNegativo);

        }


    }
}