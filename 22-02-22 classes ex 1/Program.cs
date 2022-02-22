using System;

namespace _22_02_22_classes_ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Leerling gegevens = new Leerling();
                Console.WriteLine("Wat is de voornaam van de leerling?!");
                gegevens.VoorNaamLeerling = Console.ReadLine();

                Console.WriteLine("Wat is de achternaam van de leerling?!");
                gegevens.AchterNaamLeerling = Console.ReadLine();

                Console.WriteLine("Wat is de klas van de leerling?!");
                gegevens.Klasleerling = Console.ReadLine();

                Console.WriteLine("Wilt u nog een leerling toevoegen? (J/N)");
            } while (Console.ReadLine().ToUpper().Substring(1, 0) == "J");
        }
    }
}
