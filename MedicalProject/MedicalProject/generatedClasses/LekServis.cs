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
           if (l.Sifra == sifra && l.Naziv.Equals(naziv) && l.Proizvodjac.Equals(proizvodjac) && l.Cena >= minimalnaCena
               && l.Cena <= maximalnaCena)
               temp.Add(l);
       }
      return temp;
   }
   
   public void DodajLek(Lek lek)
   {
       this.lekovi.Add(lek);
       lekRepozitorijum.Sacuvaj(lek);
   }
   
   public void IzbrisiLek(int sifraLeka)
   {
       foreach (Lek l in lekovi)
       {
           if (l.Sifra == sifraLeka)
           {
               l.Izbrisan = true;
               lekRepozitorijum.Sacuvaj(l);
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
               lekRepozitorijum.Sacuvaj(l);
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