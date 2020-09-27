/***********************************************************************
 * Module:  ReceptKontroler.cs
 * Author:  Bojana
 * Purpose: Definition of the Class ReceptKontroler
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ReceptKontroler
{
    public ReceptKontroler()
    {

    }
   public List<Recept> GetSveRecepte()
   {
       return receptServis.GetSveRecepte();
   }
   
   public List<Recept> PretraziRecepte(String sifra, String lekar, String jmbgPacijenta, Lek lek)
   {
       return receptServis.PretraziRecepte(sifra, lekar, jmbgPacijenta, lek);
   }
   
   public Recept GetRecept(int sifra)
   {
       return receptServis.GetRecept(sifra);
   }
   
   public void KreirajRecept(Recept recept)
   {
       receptServis.KreirajRecept(recept);
   }

   public ReceptServis receptServis = new ReceptServis();

}