using System.Globalization;
using System.Runtime.CompilerServices;
namespace Course {

    internal class Program {
        /*
        A dona de um pensionato possui dez quartos para alugar para estudantes,
        sendo esses quartos identificados pelos números 0 a 9.
        Quando um estudante deseja alugar um quarto, deve-se registrar o nome
        e email deste estudante.
        Fazer um programa que inicie com todos os dez quartos vazios, e depois
        leia uma quantidade N representando o número de estudantes que vão
        alugar quartos (N pode ser de 1 a 10). Em seguida, registre o aluguel dos
        N estudantes. Para cada registro de aluguel, informar o nome e email do
        estudante, bem como qual dos quartos ele escolheu (de 0 a 9). Suponha
        que seja escolhido um quarto vago. Ao final, seu programa deve imprimir
        um relatório de todas ocupações do pensionato, por ordem de quarto,
        conforme exemplo.
        */
        static void Main(string[] args) {
            Quartos[] QuartosDoLocal = new Quartos[10];

            Console.Write("Quantos estudantes vão alugar quartos?(1 a 10))");
            int nEstudantes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nEstudantes; i++) {
                Console.WriteLine("Aluguel #" + i);
                Console.Write("Nome: ");
                string nomeEstudante = Console.ReadLine();
                Console.Write("E-mail: ");
                string emailEstudante = Console.ReadLine();
                Console.Write("numero do quarto( 0 a 9 ): ");
                int quartoEscolhido = int.Parse(Console.ReadLine());

                QuartosDoLocal[quartoEscolhido] = new Quartos { Nome = nomeEstudante, Email = emailEstudante, Quarto = quartoEscolhido };

            }
            for (int i = 0; i < 10; i++) {
                if (QuartosDoLocal[i] != null) {

                    int quartoAtual = QuartosDoLocal[i].Quarto++;

                    Console.WriteLine(quartoAtual +": "+ QuartosDoLocal[i]);
                    Console.WriteLine();

                }
            } ;

        }
    }
}