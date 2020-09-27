/***********************************************************************
 * Module:  LekRepozitorijum.cs
 * Author:  Bojana
 * Purpose: Definition of the Class LekRepozitorijum
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

public class LekRepozitorijum 
{
    public void Sacuvaj(List<Lek> obj)
    {
        string[] temp = new string[obj.Count];
        for (int i = 0; i < obj.Count; i++)
        {

            string temp1 = obj[i].Sifra + "-" + obj[i].Naziv + "-" + obj[i].Proizvodjac + "-" + obj[i].NaRecept + "-" + obj[i].Cena + "-" + obj[i].Izbrisan;
            temp[i] = temp1;
        }


        System.IO.File.WriteAllLines("lekovi.txt", temp);
    }

    public List<Lek> Ucitaj()
    {
        List<Lek> lekovi = new List<Lek>();
        string[] temp = System.IO.File.ReadAllLines("lekovi.txt");
        foreach (string t in temp)
        {
            string[] temp1 = t.Split('-');

            Lek lek = new Lek(Convert.ToInt32(temp1[0]), temp1[1], temp1[2], Convert.ToBoolean(temp1[3]), float.Parse(temp1[4], CultureInfo.InvariantCulture.NumberFormat), Convert.ToBoolean(temp1[5]));
            lekovi.Add(lek);
        }
        return lekovi;
    }

}