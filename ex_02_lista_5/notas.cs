using System;
using System.Linq;
class Notas
{
    static void Main()
    {

        int[] notas = new int[20];

        NotasAlunos(notas);

    }


    static void NotasAlunos(int[] notas)
    {

        Random Aleatorio = new Random();

        for (int i = 0; i < notas.Length; i++)
        {
            notas[i] = Aleatorio.Next(100);

            Console.WriteLine("Nota do aluno {0} é : {1}", i + 1, notas[i]);
        }

        MediaEContagem(notas);
    }
    static void MediaEContagem(int[] n)
    {
        int totalDaTurma = 0;
        for (int i = 0; i < n.Length; i++)
        {
            totalDaTurma = totalDaTurma + n[i];

        }
        int media = totalDaTurma / n.Length;
        Console.WriteLine("A nota total da turma foi {0}", totalDaTurma);
        Console.WriteLine("A media da Turma é : {0}  ", media);


        for (int j = 0; j <= n.Length; j++)
        {
            if (n[j] > media)
            {
                int pos = j+1;
                Console.WriteLine("o aluno {0} ficou acima da media", pos);
            }

        }
    }

}