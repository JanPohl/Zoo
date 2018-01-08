using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Tier
{
    //private string _name;

    //public string Name { get { return _name; } private set { _name = value; } }

    // Property
    public string Name { get; private set; }

    // Property
    protected int Alter { private get; set; }

    //public string GetName()
    //{
    //    return _name;
    //}

    //public void SetName(string name)
    //{
    //    if (name == "Name")
    //    {
    //        _name = name;
    //    }
    //}

    public Tier(string name)
    {
        Name = name;
    }

    public virtual void Füttern()
    {
        Console.WriteLine("Ohm Nom Nom");
        Console.WriteLine("Das Tier mit folgendem Namen wurde gefüttert: " + Name);
    }

    public abstract void SchlafEin();
}
