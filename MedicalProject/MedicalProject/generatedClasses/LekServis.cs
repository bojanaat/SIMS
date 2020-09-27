/***********************************************************************
 * Module:  LekServis.cs
 * Author:  Bojana
 * Purpose: Definition of the Class LekServis
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class LekServis
{
    public LekServis() {
        this.lekovi = lekRepozitorijum.Ucitaj();
    }
   public List<Lek> GetSveLekove()
   {
       return lekovi;
   }
   
   public List<Lek> PretraziLekove(int sifra, String naziv, String proizvodjac, float minimalnaCena, float maximalnaCena)
   {
       List<Lek> temp = new List<Lek>();
       foreach (Lek l in lekovi)
       {
           if (sifra != 0 && l.Sifra != sifra)
               continue;

           if (minimalnaCena>l.Cena)
               continue;

           if (maximalnaCena < l.Cena)
               continue;

           if (!naziv.Equals("") && !l.Naziv.Contains(naziv))
               continue;

           if (!proizvodjac.Equals("") && !l.Proizvodjac.Contains(proizvodjac))
               continue;

           temp.Add(l);
       }
      return temp;
   }
   
   public void DodajLek(Lek lek)
   {
       this.lekovi.Add(lek);
       lekRepozitorijum.Sacuvaj(lekovi);
   }
   
   public void IzbrisiLek(int sifraLeka)
   {
       foreach (Lek l in lekovi)
       {
           if (l.Sifra == sifraLeka)
           {
               l.Izbrisan = true;
               lekRepozitorijum.Sacuvaj(lekovi);
               break;
           }
           
       }
   }
   
   public void AzurirajLek(Lek lek)
   {
       foreach (Lek l in lekovi)
       {
           if (l.Sifra == lek.Sifra)
           {
               l.Proizvodjac = lek.Proizvodjac;
               l.NaRecept = lek.NaRecept;
               l.Naziv = lek.Naziv;
               l.Cena = lek.Cena;
               lekRepozitorijum.Sacuvaj(lekovi);
               break;
           }

       }
   }
   
   public Lek GetLek(int sifra)
   {
       foreach (Lek l in lekovi)
       {
           if (l.Sifra == sifra)
           {
               return l;
           }

       }

       return null;
   }

   public List<Lek> lekovi;
   
   
   /// <pdGenerated>default removeAll</pdGenerated>
   public void RemoveAllLek()
   {
      if (lekovi != null)
         lekovi.Clear();
   }
   public LekRepozitorijum lekRepozitorijum = new LekRepozitorijum();

}