using System;

class Escolar
{

    static void Main()
    {
        Console.WriteLine("Qual a quantidade de alunos que serão consultados?");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            {
                float Resposta = 0;
                Console.WriteLine("Digite o procedimento a ser feito nas notas");
                string Letra = Console.ReadLine();


                Console.WriteLine("Digite a Primeira Nota");
                float nota1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite a Segunda Nota");
                float nota2 = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite a terceira nota");
                float nota3 = float.Parse(Console.ReadLine());


                if (Letra == "A" || Letra == "a")
                {

                    Resposta = TomadaDeDecisao(Letra, nota1, nota2, nota3);

                    Console.WriteLine("A media aritmética das notas {0}, {1}, {2}, é {3}", nota1, nota2, nota3, Resposta);

                }
                else if (Letra == "P" || Letra == "p")
                {

                    Resposta = TomadaDeDecisao(Letra, nota1, nota2, nota3);

                    Console.WriteLine("A media Ponderada das notas {0}, {1}, {2}, é {3}", nota1, nota2, nota3, Resposta);
                }

            }

            Console.WriteLine("Programa encerrado.");


        }

    }


    static float TomadaDeDecisao(string opcao, float nota1, float nota2, float nota3)
    {
        float Retorno = 0;

        if (opcao == "A" || opcao == "a")
        {
            Retorno = calcula(nota1, nota2, nota3);

        }
        else if (opcao == "P" || opcao == "p")
        {
            Retorno = Ponderada(nota1, nota2, nota3);
        }

        return Retorno;

    }
    static float calcula(float nota1, float nota2, float nota3)
    {
        float Retorno = (nota1 + nota2 + nota3) / 3;
        return Retorno;
    }

    static float Ponderada(float n1, float n2, float n3)
    {

        float peso1 = n1 * 5;
        float peso2 = n2 * 3;
        float peso3 = n3 * 2;
        float FatorDivisor = 5 + 3 + 2;

        float Retorno = (peso1 + peso2 + peso3) / FatorDivisor;


        return Retorno;
    }
}
