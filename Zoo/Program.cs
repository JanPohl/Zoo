using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    public static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.Clear();

        Zoo neuerZoo = new Zoo("Tophs Zoo");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Willkommen im Zoo: " + neuerZoo.ZooName);
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine("Die Tiere werden produziert...");
        
        // Zehn Schweine werden erstellt
        for (int i = 0; i < 10; i++)
        {
            neuerZoo.NeuesSchwein("Schnauzer" + i);
        }

        // EIn Hai und ein Wal werden erstellt
        neuerZoo.NeuerHai("Haiii");
        neuerZoo.NeuerWal("Walii");

        Console.WriteLine("Alle tiere sind fertig!");

        //int j = 0;
        //while (j < 10)
        //{
        //    neuerZoo.NeuesSchwein("Gerlinde " + j);
        //    j++;
        //}

        neuerZoo.FütterAlleTiere();

        while (true)
        {
            Console.WriteLine("Welches Tier möchtest du streicheln?");
            string nameVonDemSchweinDasGestreicheltWerdenSoll = Console.ReadLine();

            if (nameVonDemSchweinDasGestreicheltWerdenSoll == "stop")
            {
                break;
            }
            else
            {
                neuerZoo.StreichelFolgendesTier(nameVonDemSchweinDasGestreicheltWerdenSoll);
            }
        }

        //Console.Read();
    }
}
