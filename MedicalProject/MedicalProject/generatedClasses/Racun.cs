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
    private Dictionary<Lek, int> lekovi = new Dictionary<Lek, int>();

    public Dictionary<Lek, int> Lekovi
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

   public override string ToString()
   {
       
       string s = "Sifra: " + sifra + ", Farmaceut: " + farmaceut + ", Datum: " + dat + ", Cena: " + cena + ", Lekovi: ";
       
       foreach(KeyValuePair<Lek,int> par in this.Lekovi) {
            s += "Sifra: " + par.Key.Sifra +" kolicina: " + par.Value + " ";
       }
       s+=Environment.NewLine;
       return s;
   } 

}