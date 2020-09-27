/***********************************************************************
 * Module:  Racun.cs
 * Author:  Bojana
 * Purpose: Definition of the Class Racun
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Racun
{
    private List<Lek> lekovi = new List<Lek>();

    public List<Lek> Lekovi
    {
        get { return lekovi; }
        set { lekovi = value; }
    }
   
   
   /// <pdGenerated>default removeAll</pdGenerated>
   public void RemoveAllLekovi()
   {
      if (lekovi != null)
         lekovi.Clear();
   }

   private int sifra;

   public int Sifra
   {
       get { return sifra; }
       set { sifra = value; }
   }
   private string farmaceut;

   public string Farmaceut
   {
       get { return farmaceut; }
       set { farmaceut = value; }
   }
   private string dat;

   public string Dat
   {
       get { return dat; }
       set { dat = value; }
   }
   private float cena;

   public float Cena
   {
       get { return cena; }
       set { cena = value; }
   }

   public Racun() { }

   public Racun(int sifra, String farmaceut, String datum, float cena) {
       Sifra = sifra;
       Farmaceut = farmaceut;
       Dat = datum;
       Cena = cena;
   }

}