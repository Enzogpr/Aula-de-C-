namespace aula9_switch
{
    class Switch_case
    {
        static void Main()
        {
            int tempo = 0, escolha = 0;
            Console.WriteLine("Belo Horizonte/MG a Vitoria/ES");

            Console.WriteLine("---------Escola o transporte---------");

            Console.WriteLine("[1] Avisão  [2]Carro  [3] Onibus");

            escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {

                case 1:
                    tempo = 50;
                    break;

                case 2:
                    tempo = 480;
                    break;

                case 3:
                    tempo = 600;
                    break;

                default:
                    tempo = -1;
                    break;
            }

            if (tempo < 0)
            {
                Console.WriteLine("Transporte inexistente");
            }
            else
            {

                Console.WriteLine("O tempo da viagem é {0} minutos", tempo);
            }
        }
    }
}