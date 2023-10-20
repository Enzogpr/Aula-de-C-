namespace Aula6
{
    //     class Program
    //    {

    //        enum Daysemana { Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado };
    //        static void Main()
    //        {
    //            Daysemana ds = (Daysemana)3;

    //            Console.WriteLine(ds);
    //        }  
    //    }
    //}

    class Program
    {

        enum Daysemana { Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado };
        static void Main()
        {
            int ds = (int)Daysemana.Sexta;

            Console.WriteLine(ds);
        }
    }
}