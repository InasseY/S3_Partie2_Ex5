using System;

namespace Partie2_Ex5
{
    class Program
    {
        static void Main(string[] args)

        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine("Saissisez un mois parmis les douze disponibles ");
            string saison = Console.ReadLine().ToLowerInvariant();
            

            switch (saison)
            {
                case ("janvier"):
                case ("février"):
                case ("mars"):

                    Console.WriteLine(" L'hivers est la !");
                    break;
                case ("avril"):
                case ("mai"):
                case ("juin"):

                    Console.WriteLine(" Le printemps est la ! ");
                    break;
                case ("juillet"):
                case ("aout"):
                case ("septembre"):

                    Console.WriteLine(" L'été est la !");
                    break;
                case ("octobre"):
                case ("novembre"):
                case ("décembre"):

                    Console.WriteLine(" L'automne est la !");
                    break;

                default:
                    Console.WriteLine("Quoi ? Tu ne sais pas nous sommes en quel mois ?!");
                    break;


            }
}
    }
}

