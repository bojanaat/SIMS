/***********************************************************************
 * Module:  KorisnikKontroler.cs
 * Author:  Bojana
 * Purpose: Definition of the Class KorisnikKontroler
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class KorisnikKontroler
{
    
    public KorisnikKontroler() {
        korisnikServis = new KorisnikServis();
    }

   public Korisnik Logovanje(String korisnickoIme, String sifra)
   {
       return korisnikServis.Logovanje(korisnickoIme, sifra);
   }
   
   public Boolean Registracija(Korisnik korisnik)
   {
      return korisnikServis.Registracija(korisnik);
   }
   
   public List<Korisnik> GetSveKorisnike()
   {
      return korisnikServis.GetSveKorisnike();
   }

   public KorisnikServis korisnikServis;

}