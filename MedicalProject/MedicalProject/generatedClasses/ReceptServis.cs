/***********************************************************************
 * Module:  ReceptServis.cs
 * Author:  Bojana
 * Purpose: Definition of the Class ReceptServis
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ReceptServis
{
    public ReceptServis()
    {
        this.recepti = receptRepozitorijum.Ucitaj();
    }
   public List<Recept> GetSveRecepte()
   {
       return recepti;
   }
   
   public List<Recept> PretraziRecepte(String sifra, String lekar, String jmbgPacijenta, Lek lek)
   {
       List<Recept> temp = new List<Recept>();
       foreach (Recept r in recepti)
       {
           if (!sifra.Equals("") && r.Sifra != sifra)
               continue;

           if (!lekar.Equals("") && !lekar.Equals(r.Doktor))
               continue;

           if (!jmbgPacijenta.Equals("") && !jmbgPacijenta.Equals(r.JmbgPacijenta))
               continue;

           if (lek!=null && !lek.Sifra.Equals(r.Doktor))
               continue;


           temp.Add(r);
       }
       return temp;
   }
   
   public Recept GetRecept(int sifra)
   {
       foreach (Recept r in recepti)
       {
           if (r.Sifra.Equals(sifra.ToString()))
           {
               return r;
           }

       }

       return null;
   }
   
   public void KreirajRecept(Recept recept)
   {
       this.recepti.Add(recept);
       receptRepozitorijum.Sacuvaj(recepti);
   }

   public List<Recept> recepti = new List<Recept>();
   
   /// <pdGenerated>default Remove</pdGenerated>
   public void RemoveRecept(Recept oldRecept)
   {
      if (oldRecept == null)
         return;
      if (this.recepti != null)
         if (this.recepti.Contains(oldRecept))
            this.recepti.Remove(oldRecept);
   }
   
   /// <pdGenerated>default removeAll</pdGenerated>
   public void RemoveAllRecept()
   {
      if (recepti != null)
         recepti.Clear();
   }
   public ReceptRepozitorijum receptRepozitorijum = new ReceptRepozitorijum();

}