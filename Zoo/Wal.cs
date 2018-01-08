using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Wal : Tier, IStreichelbar
{
    public Wal(string name) : base(name)
    {
        Console.WriteLine("Ein Wal ist ins Wasser gefallen!");
    }

    public void Streicheln()
    {
        Console.WriteLine("Blub Blub Blub, Ich bin: " + Name);
    }

    public override void SchlafEin()
    {
        Console.WriteLine("Blub Blub");
    }
}
