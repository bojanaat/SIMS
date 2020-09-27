/***********************************************************************
 * Module:  ReceptRepozitorijum.cs
 * Author:  Bojana
 * Purpose: Definition of the Class ReceptRepozitorijum
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ReceptRepozitorijum 
{
    public void Sacuvaj(List<Recept> obj)
    {
        string[] temp = new string[obj.Count];
        for (int i = 0; i < obj.Count; i++)
        {

            string temp1 = obj[i].Sifra + "-" + obj[i].Sifra + "-" + obj[i].Doktor + "-" + obj[i].JmbgPacijenta + "-" + obj[i].DatumVreme+"-";

            foreach (KeyValuePair<Lek, int> par in obj[i].Lekovi)
            {
                temp1 += par.Key.Sifra + "|" + par.Value + ",";
            }
            temp1 = temp1.Substring(0, temp1.Length - 1);
            temp[i] = temp1;


        }


        System.IO.File.WriteAllLines("recepti.txt", temp);
    }

    public List<Recept> Ucitaj()
    {
        List<Recept> recepti = new List<Recept>();
        string[] temp = System.IO.File.ReadAllLines("recepti.txt");
        foreach (string t in temp)
        {
            string[] temp1 = t.Split('-');

            Recept recept = new Recept(temp1[0], temp1[1], temp1[2], temp1[3]);
            String[] lekovi = temp1[4].Split(',');
            for (int i = 0; i < lekovi.Length; i++)
            {
                String[] temp2 = lekovi[i].Split('|');
                Lek lek = new Lek();
                lek.Sifra = Convert.ToInt32(temp2[0]);

                recept.Lekovi.Add(lek,Convert.ToInt32(temp2[1]));
            }
            
            recepti.Add(recept);
        }
        return recepti;
    }

}