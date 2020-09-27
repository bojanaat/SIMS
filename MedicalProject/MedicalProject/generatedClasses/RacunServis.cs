/***********************************************************************
 * Module:  RacunServis.cs
 * Author:  Bojana
 * Purpose: Definition of the Class RacunServis
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class RacunServis
{
    public RacunServis()
    {
        racuni = racunRepozitorijum.Ucitaj();
    }

   public void KreirajRacun(Racun racun)
   {
       this.racuni.Add(racun);
       racunRepozitorijum.Sacuvaj(racuni);
   }



   public RacunRepozitorijum racunRepozitorijum = new RacunRepozitorijum();
   public List<Racun> racuni = new List<Racun>();
   
   /// <pdGenerated>default removeAll</pdGenerated>
   public void RemoveAllRacuni()
   {
      if (racuni != null)
         racuni.Clear();
   }

}