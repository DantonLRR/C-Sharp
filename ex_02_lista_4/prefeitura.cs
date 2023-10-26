using System;

class Prefeitura
{
static void Main()
{
 Retorno();


}
    static void Retorno()
    {
        Console.WriteLine("Qual a quantidade de pessoas abordadas na pesquisa?");
        float pessoas = float.Parse(Console.ReadLine());
        float i = 0;
        float somaSalario = 0;

        while (i < pessoas)
        {
            Console.WriteLine("Qual o Salario ?");
            float salario = float.Parse(Console.ReadLine());
            somaSalario += salario; 

            Console.WriteLine("Qual a Quantidade de filhos");
            float qntFilhos = float.Parse(Console.ReadLine());

            i++;
        }

        float ResultadoSalario = calculoSalario(somaSalario, pessoas);

        Console.WriteLine("A média do salario é {0}",ResultadoSalario);
        

    }

    static float calculoSalario(float salario, float pessoas)
    {
        float Resultado = salario / pessoas;
        return Resultado;

    }




}