using System.Runtime.CompilerServices;

//namespace Aula5
//{
//     class Entrada_de_valores
//    {

//        static void Main(string[] args)
//        {
//            int v1, v2, sum;
//            string name;

//            Console.Write("Digite seu nome: ");
//            name = Console.ReadLine();
//            Console.WriteLine("Nome digitado: " + name);
//        }
//    }
//}

namespace Aula5
{
    class calculadora_simples
    {
        static void Main()
        {
            float v1, v2, v3;

            int operação;
            float soma, subtração, divisão, multiplicação;

            Console.WriteLine("Digite o primeiro valor: ");
            v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual a operação desejada? ");
            Console.WriteLine("[1] Soma      [3] Divisão");
            Console.WriteLine("[2] Subtração [4] Multiplicação");
            operação = int.Parse(Console.ReadLine());

            if (operação == 1)
            {
                soma = v1 + v2;
                Console.WriteLine("O resultado é: " + soma);
            }
            else if (operação == 2)
            {
                subtração = v1 - v2;
                Console.WriteLine("O resultado é: " + subtração);
            }
            else if (operação == 3)
            {
                divisão = v1 / v2;
                Console.WriteLine("O resultado é: " + divisão);
            }
            else if (operação == 4)
            {
                multiplicação = v1 * v2;
                Console.WriteLine("O resultado é: " + multiplicação);
            }
            else
            {
                Console.WriteLine("Operãção não disponivel");
            }

        }
    }
}