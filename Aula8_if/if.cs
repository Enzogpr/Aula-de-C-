namespace Aula8_if
{
    class C_if
    {
        static void Main()
        {
            int nota;
            string resultado = "aprovado";

            Console.WriteLine("Digite a nota: ");
            nota = int.Parse(Console.ReadLine());
            if (nota >= 60)
            {
                Console.WriteLine("------------Resultado-------------\n");
                Console.WriteLine("            {0}",resultado);
            } 
            else
            {
                Console.WriteLine("------------Resultado-------------\n");
                resultado = "Reprovado";
                Console.WriteLine("              {0}   ",resultado);
            }
        }
    }
}
