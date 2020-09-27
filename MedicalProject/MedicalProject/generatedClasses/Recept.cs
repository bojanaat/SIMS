/***********************************************************************
 * Module:  Recept.cs
 * Author:  Bojana
 * Purpose: Definition of the Class Recept
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Recept
{
    private List<Lek> lekovi = new List<Lek>();

    public List<Lek> Lekovi
    {
        get { return lekovi; }
        set { lekovi = value; }
    }
   
   
   /// <pdGenerated>default removeAll</pdGenerated>
   public void RemoveAllLekkovi()
   {
      if (lekovi != null)
         lekovi.Clear();
   }

   private string sifra;

   public string Sifra
   {
       get { return sifra; }
       set { sifra = value; }
   }
   private string doktor;

   public string Doktor
   {
       get { return doktor; }
       set { doktor = value; }
   }
   private string jmbgPacijenta;

   public string JmbgPacijenta
   {
       get { return jmbgPacijenta; }
       set { jmbgPacijenta = value; }
   }
   private string datumVreme;

   public string DatumVreme
   {
       get { return datumVreme; }
       set { datumVreme = value; }
   }

   public Recept() { }

   public Recept(String sifra, String doktor, String jmbgPacijenta, String datumVreme)
   {
       Sifra = sifra;
       Doktor = doktor;
       JmbgPacijenta = jmbgPacijenta;
       DatumVreme = datumVreme;
   }

}