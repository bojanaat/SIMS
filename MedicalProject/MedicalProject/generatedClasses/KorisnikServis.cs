/***********************************************************************
 * Module:  KorisnikServis.cs
 * Author:  Bojana
 * Purpose: Definition of the Class KorisnikServis
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class KorisnikServis
{
    private List<Korisnik> korisnici = new List<Korisnik>();

    public KorisnikServis()
    {
        this.korisnici = korisnikRepozitorijum.Ucitaj();
    }

   public Korisnik Logovanje(String korisnickoIme, String sifra)
   {
       foreach (Korisnik k in korisnici)
       {
           if (k.KorisnickoIme.Equals(korisnickoIme) && k.Sifra.Equals(sifra))
           {
               ulogovaniKorisnik = k;
               return k;
           }
       }

       return null;
   }
   
   public Boolean Registracija(Korisnik korisnik)
   {
       foreach(Korisnik k in korisnici)
           if(k.KorisnickoIme.Equals(korisnik.KorisnickoIme))
               return false;

       this.korisnici.Add(korisnik);
       //writing to file
       korisnikRepozitorijum.Sacuvaj(korisnik);
       return true;
   }
   
   public List<Korisnik> GetSveKorisnike()
   {
      return korisnici;
   }


   
   
   /// <pdGenerated>default Remove</pdGenerated>
   public void RemoveKorisnik(Korisnik oldKorisnik)
   {
      if (oldKorisnik == null)
         return;
      if (this.korisnici != null)
         if (this.korisnici.Contains(oldKorisnik))
            this.korisnici.Remove(oldKorisnik);
   }
   
   /// <pdGenerated>default removeAll</pdGenerated>
   public void RemoveAllKorisnik()
   {
      if (korisnici != null)
         korisnici.Clear();
   }
   public KorisnikRepozitorijum korisnikRepozitorijum;
   public Korisnik ulogovaniKorisnik;

}