/***********************************************************************
 * Module:  RacunRepozitorijum.cs
 * Author:  Bojana
 * Purpose: Definition of the Class RacunRepozitorijum
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

public class RacunRepozitorijum 
{
    public void Sacuvaj(List<Racun> obj)
    {
        string[] temp = new string[obj.Count];
        for (int i = 0; i < obj.Count; i++)
        {

            string temp1 = obj[i].Sifra + "-" + obj[i].Farmaceut + "-" + obj[i].Dat + "-" + obj[i].Cena;
            temp[i] = temp1;
        }


        System.IO.File.WriteAllLines("racuni.txt", temp);
    }

    public List<Racun> Ucitaj()
    {
        List<Racun> racuni= new List<Racun>();
        string[] temp = System.IO.File.ReadAllLines("racuni.txt");
        foreach (string t in temp)
        {
            string[] temp1 = t.Split('-');

            Racun racun = new Racun(Convert.ToInt32(temp1[0]), temp1[1], temp1[2], float.Parse(temp1[3], CultureInfo.InvariantCulture.NumberFormat));
            racuni.Add(racun);
        }
        return racuni;
    }


}