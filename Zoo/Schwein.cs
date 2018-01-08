using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Schwein : Tier, IStreichelbar
{
    private int _streichelCount = 0;

    public Schwein(string name) : base(name)
    {
        Console.WriteLine("Ein Schwein wurde geboren!");
    }

    public void Streicheln()
    {
        switch (_streichelCount)
        {
            case 0:
            case 1:
            case 2:
                Console.WriteLine("Das tut gut!");
                break;
            case 3:
                Console.WriteLine("oh ja!");
                break;
            default:
                Console.WriteLine("So langsam scheuerts!");
                break;
        }

        Console.WriteLine("Das Tier mit folgendem Namen wurde gestreichelt: " + Name);

        _streichelCount++;
    }

    public void DuHastGeburtstag()
    {
        Alter = 3;
    }

    public override void Füttern()
    {
        Console.WriteLine("Das Tier mit folgendem Namen wurde gefüttert: " + Name);
    }

    public override void SchlafEin()
    {
        Console.WriteLine("Grunz, Grunz");
    }
}
