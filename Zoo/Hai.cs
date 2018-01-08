using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Hai : Tier
{
    public Hai(string name) : base(name)
    {
        
    }

    public void FrissDenTaucher()
    {
        Console.WriteLine("Der Hai: " + Name + " greift den Taucher an!");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Blut spritzt!!!!!!");
        Console.ForegroundColor = ConsoleColor.White;
    }

    public override void SchlafEin()
    {
        Console.WriteLine("Ich darf nicht ganz einschlafen, sondern nur halb!!!");
    }
}
