/***********************************************************************
 * Module:  Lek.cs
 * Author:  Bojana
 * Purpose: Definition of the Class Lek
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Lek
{
    private int sifra;

    public int Sifra
    {
        get { return sifra; }
        set { sifra = value; }
    }
    private string naziv;

    public string Naziv
    {
        get { return naziv; }
        set { naziv = value; }
    }
    private string proizvodjac;

    public string Proizvodjac
    {
        get { return proizvodjac; }
        set { proizvodjac = value; }
    }
    private bool naRecept;

    public bool NaRecept
    {
        get { return naRecept; }
        set { naRecept = value; }
    }
    private float cena;

    public float Cena
    {
        get { return cena; }
        set { cena = value; }
    }
    private bool izbrisan;

    public bool Izbrisan
    {
        get { return izbrisan; }
        set { izbrisan = value; }
    }

   public Lek() { }

   public Lek(int sifra, String naziv, String proizvodjac, bool naRecept, float cena, bool izbrisan) {
       Sifra = sifra;
       Naziv = naziv;
       Proizvodjac = proizvodjac;
       NaRecept = naRecept;
       Cena = cena;
       Izbrisan = izbrisan;
   }

   public override string ToString()
   {
       if (this.izbrisan)
           return "";

       string s = "Sifra: " + sifra + ", Naziv: " + naziv + ", Proizvodjac: " + proizvodjac + ", Na recept: " + naRecept + ", Cena: " + cena + Environment.NewLine;
       return s;
   } 
}