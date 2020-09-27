/***********************************************************************
 * Module:  KorisnikRepozitorijum.cs
 * Author:  Bojana
 * Purpose: Definition of the Class KorisnikRepozitorijum
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;

public class KorisnikRepozitorijum
{
   public void Sacuvaj(List<Korisnik> obj)
   {
       string[] temp = new string[obj.Count];
       for (int i = 0; i < obj.Count; i++)
       {
           string temp1 = obj[i].KorisnickoIme + "-" + obj[i].Sifra + "-" + obj[i].Ime + "-" + obj[i].Prezime + "-" + obj[i].Uloga;
           temp[i] = temp1;
       }


       System.IO.File.WriteAllLines("korisnici.txt", temp);
   }
   
   public List<Korisnik> Ucitaj()
   {
       List<Korisnik> korisnici = new List<Korisnik>();
       string[] temp = System.IO.File.ReadAllLines("korisnici.txt");
       foreach (string t in temp)
       {
           string[] temp1 = t.Split('-');
           Korisnik korisnik = new Korisnik(temp1[0], temp1[1], temp1[2], temp1[3], (Uloga)Enum.Parse(typeof(Uloga), temp1[4], true));
           korisnici.Add(korisnik);
       }
       return korisnici;
   }

}