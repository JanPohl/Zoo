using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Zoo
{
    public string ZooName { get; private set; } = "Mein Zoo";

    //Tier[] _schweine = new Tier[3];

    private List<Tier> _tiere = new List<Tier>();

    //private int _anzahlSchweine = 0;

    public Zoo(string name)
    {
        ZooName = name;
    }

    public void FütterAlleTiere()
    {
        //for (int i = 0; i < _schweineListe.Count; i++)
        //{
        //    _schweineListe[i].Füttern();
        //}


        foreach(Tier tier in _tiere)
        {
            tier.Füttern();
        }
    }

    public void StreichelFolgendesTier(string name)
    {
        foreach(Tier tier in _tiere)
        {
            if(tier is IStreichelbar && name == tier.Name)
            {
                IStreichelbar streichelbaresTier = tier as IStreichelbar;
                streichelbaresTier.Streicheln();
            }
        }
    }

    public void NeuerHai(string name)
    {
        Hai neuerHai = new Hai(name);
        _tiere.Add(neuerHai);
        neuerHai.FrissDenTaucher();
    }

    public void NeuerWal(string name)
    {
        Wal neuerWal = new Wal(name);
        _tiere.Add(neuerWal);
        neuerWal.Streicheln();
    }

    public void NeuesSchwein(string name)
    {
        //bool gibtEsSchon = false;

        //for(int i = 0; i < _schweineListe.Count; i++)
        //{
        //    if(name == _schweineListe[i].Name)
        //    {
        //        gibtEsSchon = true;
        //    }
        //}

        //if (gibtEsSchon == false)
        if(_tiere.Exists(tier => tier.Name == name) == false)
        {
            //_schweine[0] = new Tier(name);

            Schwein neuesSchwein = new Schwein(name);
            _tiere.Add(neuesSchwein);

            Console.WriteLine("Du hast ein neues Schwein in deinem Zoo!");
            Console.WriteLine("Dein Schwein heißt: " + neuesSchwein.Name);



            //_anzahlSchweine = _anzahlSchweine + 1;
            //_anzahlSchweine += 1;
            //_anzahlSchweine++;

            Console.WriteLine("Deine Anzahl Schweine ist nun: " + _tiere.Count);
        }
        else
        {
            Console.WriteLine("Der folgende Name existiert schon: " + name);
            Console.WriteLine("Deine Anzahl Schweine bleibt: " + _tiere.Count);
        }
    }
}
