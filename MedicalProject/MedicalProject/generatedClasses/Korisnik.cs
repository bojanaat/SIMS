/***********************************************************************
 * Module:  Korisnik.cs
 * Author:  Bojana
 * Purpose: Definition of the Class Korisnik
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public enum Uloga
{
    ADMINISTRATOR, LEKAR, APOTEKAR
}
public class Korisnik
{
    private string korisnickoIme;

    public string KorisnickoIme
    {
        get { return korisnickoIme; }
        set { korisnickoIme = value; }
    }
    private string sifra;

    public string Sifra
    {
        get { return sifra; }
        set { sifra = value; }
    }
    private string ime;

    public string Ime
    {
        get { return ime; }
        set { ime = value; }
    }
    private string prezime;

    public string Prezime
    {
        get { return prezime; }
        set { prezime = value; }
    }
    private Uloga uloga;

    public Uloga Uloga
    {
        get { return uloga; }
        set { uloga = value; }
    }

   public Korisnik() { }

   public Korisnik(String koriscnikoIme, String sifra, String ime, String prezime, Uloga uloga)
   {
       KorisnickoIme = koriscnikoIme;
       Sifra = sifra;
       Ime = ime;
       Prezime = prezime;
       Uloga = uloga;
   }

   public override string ToString() {
       string s = "Korisnicko ime: " + korisnickoIme + ", Ime: " + ime + ", Prezime: " + prezime + ", Uloga: " + uloga + Environment.NewLine;
       return s;
   } 

}