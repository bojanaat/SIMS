/***********************************************************************
 * Module:  LekKontroler.cs
 * Author:  Bojana
 * Purpose: Definition of the Class LekKontroler
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class LekKontroler
{
    public LekKontroler() { }
   public List<Lek> GetSveLekove()
   {
       return lekServis.GetSveLekove();
   }
   
   public List<Lek> PretraziLekove(int sifra, String naziv, String proizvodjac, float minimalnaCena, float maximalnaCena)
   {
       return lekServis.PretraziLekove(sifra, naziv, proizvodjac, minimalnaCena, maximalnaCena);
   }
   
   public void DodajLek(Lek lek)
   {
       lekServis.DodajLek(lek);
   }
   
   public void IzbrisiLek(int sifraLeka)
   {
       lekServis.IzbrisiLek(sifraLeka);
   }
   
   public void AzurirajLek(Lek lek)
   {
       lekServis.AzurirajLek(lek);
   }
   
   public Lek GetLek(int sifra)
   {
       return lekServis.GetLek(sifra);
   }
   
   public void KreirajRacun(Racun racun)
   {
       racunServis.KreirajRacun(racun);
   }

   public LekServis lekServis = new LekServis();
   public RacunServis racunServis = new RacunServis();

}