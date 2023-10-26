using System;

class Numeros
{

    static void Main()
    {
        Console.WriteLine("Verifique se o numero informado é par ou impar");
        int num1 = int.Parse(Console.ReadLine());

       
       int Retorno =  ParOuImpar(num1);
        if (Retorno == 1)
        {
            
            Console.WriteLine("o numero digitado  é Par");
        }
        else
        {
            Console.WriteLine("o numero digitado foi é Impar");
        }
    }

    public static int ParOuImpar(int x)
    { 
        int Retorno = 0;

        if (x % 2 == 0)
        {
             Retorno = 1;
        }
        else{
            Retorno = 0;
        }
        return Retorno;
    }
}