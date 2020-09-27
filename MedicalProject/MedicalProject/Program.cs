using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace MedicalProject
{
    class Program
    {
        public static KorisnikKontroler korisnikKontroler = new KorisnikKontroler();
        public static LekKontroler lekKontroler = new LekKontroler();
        public static ReceptKontroler receptKontroler = new ReceptKontroler();


        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.WriteLine("LOGIN");
                Console.WriteLine("Enter username: ");
                String username = Console.ReadLine();
                Console.WriteLine("Enter password: ");
                String password = Console.ReadLine();
                Korisnik ulogovani = korisnikKontroler.Logovanje(username, password);
                if (ulogovani == null)
                {
                    Console.WriteLine("Neispravni kredencijali");
                    continue;
                }
                else
                {
                    Console.WriteLine("Uspesno");
                    if (ulogovani.Uloga == Uloga.ADMINISTRATOR)
                        AdministratorMeni();
                    else if (ulogovani.Uloga == Uloga.LEKAR)
                        LekarMeni();
                    else
                        ApotekarMeni();
                    
                }       
                    
                

            }
        }

        static void AdministratorMeni() {
            while (true)
            {
                Console.WriteLine("1. Prikaz lekova");
                Console.WriteLine("2. Pretraga lekova");
                Console.WriteLine("3. Prikaz recepata");
                Console.WriteLine("4. Pretraga recepata");
                Console.WriteLine("5. Registracija");
                Console.WriteLine("6. Prikaz korisnika");
                Console.WriteLine("7. Kreiranje izvestaja");
                Console.WriteLine("8. Dodavanje leka");
                Console.WriteLine("9. Izmena leka");
                Console.WriteLine("10. Brisanje leka");
                Console.WriteLine("11. Odloguj se");

                int opcija = Convert.ToInt32(Console.ReadLine());
                switch (opcija)
                {
                    case 1:
                        {
                            List<Lek> lekovi = lekKontroler.GetSveLekove();
                            foreach (Lek lek in lekovi)
                            {
                                Console.WriteLine(lek.ToString());
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Uneti parametre za pretragu: ");
                            Console.WriteLine("Sifra (0 ako nije potrebno pretraziti po sifri): ");
                            int sifra = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Naziv: ");
                            String naziv = Console.ReadLine();
                            Console.WriteLine("Proizvodjac: ");
                            String proizvodjac = Console.ReadLine();
                            Console.WriteLine("Minimalna cena: ");
                            float minCena = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);
                            Console.WriteLine("Maksimalna cena: ");
                            float maxCena = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);
                            List<Lek> lekovi = lekKontroler.PretraziLekove(sifra, naziv, proizvodjac, minCena, maxCena);
                            foreach (Lek lek in lekovi)
                            {
                                Console.WriteLine(lek.ToString());
                            }
                            break;
                            
                        }
                    case 3:
                        {
                            List<Recept> recepti = receptKontroler.GetSveRecepte();
                            foreach (Recept r in recepti)
                            {
                                Console.WriteLine(r.ToString());
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Uneti parametre za pretragu: ");
                            Console.WriteLine("Sifra (0 ako nije potrebno pretraziti po sifri): ");
                            String sifra = Console.ReadLine();
                            Console.WriteLine("Lekar: ");
                            String lekar = Console.ReadLine();
                            Console.WriteLine("Jmbg pacijenta: ");
                            String jmbg = Console.ReadLine();
                            Console.WriteLine("Sifra leka: ");
                            String sLeka = Console.ReadLine();
                            List<Recept> recepti;
                            if (sLeka.Equals(""))
                            {
                                recepti = receptKontroler.PretraziRecepte(sifra, lekar, jmbg, null);
                            
                            }
                            else
                            {
                                Lek l = lekKontroler.GetLek(Convert.ToInt32(sLeka));
                                recepti = receptKontroler.PretraziRecepte(sifra, lekar, jmbg, l);
                            
                            }
                            
                            foreach (Recept r in recepti)
                            {
                                Console.WriteLine(r.ToString());
                            }
                            break;
                            
                        }
                    case 5:
                        {
                            Console.WriteLine("Uneti parametre za registraciju: ");
                            Console.WriteLine("Korisnicko ime: ");
                            String kIme = Console.ReadLine();
                            Console.WriteLine("Sifra: ");
                            String sifra = Console.ReadLine();
                            Console.WriteLine("Ime: ");
                            String ime = Console.ReadLine();
                            Console.WriteLine("Prezime: ");
                            String prezime = Console.ReadLine();
                            Console.WriteLine("Uloga: ");
                            String u = Console.ReadLine();

                            Uloga uloga = (Uloga) Enum.Parse(typeof(Uloga), u, true);
                            bool uspeh = korisnikKontroler.Registracija(new Korisnik(kIme, sifra, ime, prezime, uloga));
                            if (uspeh)
                            {
                                Console.WriteLine("Uspesno!");
                            }
                            else
                            {
                                Console.WriteLine("Korisnicko ime vec postoji!");
                            }
                            break;
                        }
                    case 6:
                        {
                            List<Korisnik> korisnici = korisnikKontroler.GetSveKorisnike();
                            foreach (Korisnik k in korisnici)
                            {
                                Console.WriteLine(k.ToString());
                            }
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Uneti izbor izvestaja: ");
                            Console.WriteLine("1. Ukupna prodaja lekova: ");
                            Console.WriteLine("2. Ukupna prodaja lekova nekog proizvodjaca: ");
                            Console.WriteLine("3. Ukupna prodaja lekova nekog apotekara: ");
                            int izbor = Convert.ToInt32(Console.ReadLine());
                            if (izbor == 1)
                            {
                                // to do
                            }
                            else if (izbor == 2)
                            {
                                // to do
                            }
                            else
                            {
                                // to do
                            }

                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("Uneti parametre za dodavanje leka: ");

                            Console.WriteLine("Sifra: ");
                            int sifra = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Naziv: ");
                            String naziv = Console.ReadLine();
                            Console.WriteLine("Proizvodjac: ");
                            String proizvodjac = Console.ReadLine();
                            Console.WriteLine("Na recept(true/false): ");
                            bool naRecept = Convert.ToBoolean(Console.ReadLine());
                            Console.WriteLine("Cena: ");
                            float cena = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);


                            lekKontroler.DodajLek(new Lek(sifra, naziv, proizvodjac, naRecept, cena, false));
                            break;
                        }
                    case 9:
                        {
                            Console.WriteLine("Uneti parametre za izmenu leka (sifra mora biti postojeca!): ");

                            Console.WriteLine("Sifra: ");
                            int sifra = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Naziv: ");
                            String naziv = Console.ReadLine();
                            Console.WriteLine("Proizvodjac: ");
                            String proizvodjac = Console.ReadLine();
                            Console.WriteLine("Na recept(true/false): ");
                            bool naRecept = Convert.ToBoolean(Console.ReadLine());
                            Console.WriteLine("Cena: ");
                            float cena = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);


                            lekKontroler.AzurirajLek(new Lek(sifra, naziv, proizvodjac, naRecept, cena, false));
                            break;
                        }
                    case 10:
                        {
                            Console.WriteLine("Sifra: ");
                            int sifra = Convert.ToInt32(Console.ReadLine());
                            
                            lekKontroler.IzbrisiLek(sifra);
                            break;
                        }
                    default:
                        {
                            return;
                        }
                }
            }
        }

        static void LekarMeni() 
        {
            while (true)
            {
                Console.WriteLine("1. Prikaz lekova");
                Console.WriteLine("2. Pretraga lekova");
                Console.WriteLine("3. Prikaz recepata");
                Console.WriteLine("4. Pretraga recepata");
                Console.WriteLine("5. Kreiranje recepta");
                Console.WriteLine("6. Odloguj se");
                int opcija = Convert.ToInt32(Console.ReadLine());
                switch (opcija)
                {
                    case 1:
                        {
                            List<Lek> lekovi = lekKontroler.GetSveLekove();
                            foreach (Lek lek in lekovi)
                            {
                                Console.WriteLine(lek.ToString());
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Uneti parametre za pretragu: ");
                            Console.WriteLine("Sifra (0 ako nije potrebno pretraziti po sifri): ");
                            int sifra = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Naziv: ");
                            String naziv = Console.ReadLine();
                            Console.WriteLine("Proizvodjac: ");
                            String proizvodjac = Console.ReadLine();
                            Console.WriteLine("Minimalna cena: ");
                            float minCena = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);
                            Console.WriteLine("Maksimalna cena: ");
                            float maxCena = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);
                            List<Lek> lekovi = lekKontroler.PretraziLekove(sifra, naziv, proizvodjac, minCena, maxCena);
                            foreach (Lek lek in lekovi)
                            {
                                Console.WriteLine(lek.ToString());
                            }
                            break;

                        }
                    case 3:
                        {
                            List<Recept> recepti = receptKontroler.GetSveRecepte();
                            foreach (Recept r in recepti)
                            {
                                Console.WriteLine(r.ToString());
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Uneti parametre za pretragu: ");
                            Console.WriteLine("Sifra (0 ako nije potrebno pretraziti po sifri): ");
                            String sifra = Console.ReadLine();
                            Console.WriteLine("Lekar: ");
                            String lekar = Console.ReadLine();
                            Console.WriteLine("Jmbg pacijenta: ");
                            String jmbg = Console.ReadLine();
                            Console.WriteLine("Sifra leka: ");
                            String sLeka = Console.ReadLine();
                            List<Recept> recepti;
                            if (sLeka.Equals(""))
                            {
                                recepti = receptKontroler.PretraziRecepte(sifra, lekar, jmbg, null);

                            }
                            else
                            {
                                Lek l = lekKontroler.GetLek(Convert.ToInt32(sLeka));
                                recepti = receptKontroler.PretraziRecepte(sifra, lekar, jmbg, l);

                            }

                            foreach (Recept r in recepti)
                            {
                                Console.WriteLine(r.ToString());
                            }
                            break;

                        }
                    case 5:
                        {
                            Console.WriteLine("Uneti parametre za kreiranje recepta: ");

                            Console.WriteLine("Sifra: ");
                            String sifra = Console.ReadLine();
                            Console.WriteLine("Doktor: ");
                            String doktor = Console.ReadLine();
                            Console.WriteLine("Jmbg pacijenta: ");
                            String jmbg = Console.ReadLine();
                            Console.WriteLine("Datum i vreme(format xx:xx:xxx): ");
                            String dat = Console.ReadLine();

                            Recept rec = new Recept(sifra, doktor, jmbg, dat);
                            Console.WriteLine("Uneti sifre i kolicine lekova (uneti -1 za sifru kada je potrebno stati sa unosom): ");
                            while (true)
                            {
                                Console.WriteLine("Sifra leka: ");
                                int sl = Convert.ToInt32(Console.ReadLine());
                                if (sl == -1)
                                    break;
                                Console.WriteLine("Kolicina: ");
                                int kol = Convert.ToInt32(Console.ReadLine());
                                rec.Lekovi.Add(lekKontroler.GetLek(sl), kol);
                            
                            }
                            
                            

                            receptKontroler.KreirajRecept(rec);
                            break;
                        }
                    default:
                        {
                            return;
                        }
                }
            }
        }

        static void ApotekarMeni() 
        {
            while (true)
            {
                Console.WriteLine("1. Prikaz lekova");
                Console.WriteLine("2. Pretraga lekova");
                Console.WriteLine("3. Prikaz recepata");
                Console.WriteLine("4. Pretraga recepata");
                Console.WriteLine("5. Dodavanje leka");
                Console.WriteLine("6. Izmena leka");
                Console.WriteLine("7. Brisanje leka");
                Console.WriteLine("8. Prodaja leka");
                Console.WriteLine("9. Odloguj se");
                int opcija = Convert.ToInt32(Console.ReadLine());
                switch (opcija)
                {
                    case 1:
                        {
                            List<Lek> lekovi = lekKontroler.GetSveLekove();
                            foreach (Lek lek in lekovi)
                            {
                                Console.WriteLine(lek.ToString());
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Uneti parametre za pretragu: ");
                            Console.WriteLine("Sifra (0 ako nije potrebno pretraziti po sifri): ");
                            int sifra = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Naziv: ");
                            String naziv = Console.ReadLine();
                            Console.WriteLine("Proizvodjac: ");
                            String proizvodjac = Console.ReadLine();
                            Console.WriteLine("Minimalna cena: ");
                            float minCena = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);
                            Console.WriteLine("Maksimalna cena: ");
                            float maxCena = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);
                            List<Lek> lekovi = lekKontroler.PretraziLekove(sifra, naziv, proizvodjac, minCena, maxCena);
                            foreach (Lek lek in lekovi)
                            {
                                Console.WriteLine(lek.ToString());
                            }
                            break;

                        }
                    case 3:
                        {
                            List<Recept> recepti = receptKontroler.GetSveRecepte();
                            foreach (Recept r in recepti)
                            {
                                Console.WriteLine(r.ToString());
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Uneti parametre za pretragu: ");
                            Console.WriteLine("Sifra (0 ako nije potrebno pretraziti po sifri): ");
                            String sifra = Console.ReadLine();
                            Console.WriteLine("Lekar: ");
                            String lekar = Console.ReadLine();
                            Console.WriteLine("Jmbg pacijenta: ");
                            String jmbg = Console.ReadLine();
                            Console.WriteLine("Sifra leka: ");
                            String sLeka = Console.ReadLine();
                            List<Recept> recepti;
                            if (sLeka.Equals(""))
                            {
                                recepti = receptKontroler.PretraziRecepte(sifra, lekar, jmbg, null);

                            }
                            else
                            {
                                Lek l = lekKontroler.GetLek(Convert.ToInt32(sLeka));
                                recepti = receptKontroler.PretraziRecepte(sifra, lekar, jmbg, l);

                            }

                            foreach (Recept r in recepti)
                            {
                                Console.WriteLine(r.ToString());
                            }
                            break;

                        }
                    case 5:
                        {
                            Console.WriteLine("Uneti parametre za dodavanje leka: ");

                            Console.WriteLine("Sifra: ");
                            int sifra = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Naziv: ");
                            String naziv = Console.ReadLine();
                            Console.WriteLine("Proizvodjac: ");
                            String proizvodjac = Console.ReadLine();
                            Console.WriteLine("Na recept(true/false): ");
                            bool naRecept = Convert.ToBoolean(Console.ReadLine());
                            Console.WriteLine("Cena: ");
                            float cena = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);


                            lekKontroler.DodajLek(new Lek(sifra, naziv, proizvodjac, naRecept, cena, false));
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Uneti parametre za izmenu leka (sifra mora biti postojeca!): ");

                            Console.WriteLine("Sifra: ");
                            int sifra = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Naziv: ");
                            String naziv = Console.ReadLine();
                            Console.WriteLine("Proizvodjac: ");
                            String proizvodjac = Console.ReadLine();
                            Console.WriteLine("Na recept(true/false): ");
                            bool naRecept = Convert.ToBoolean(Console.ReadLine());
                            Console.WriteLine("Cena: ");
                            float cena = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);

                            
                            lekKontroler.AzurirajLek(new Lek(sifra, naziv, proizvodjac, naRecept, cena, false));
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Sifra: ");
                            int sifra = Convert.ToInt32(Console.ReadLine());

                            lekKontroler.IzbrisiLek(sifra);
                            break;
                        }
                    case 8:
                        {
                            Random random = new Random();
                            int sif = random.Next(5000);
                            Racun racun = new Racun(sif, korisnikKontroler.korisnikServis.ulogovaniKorisnik.KorisnickoIme, DateTime.Now.ToShortDateString(), 0);
                            float ukupnaCena = 0;
                            while (true)
                            {
                                Console.WriteLine("1. Dodaj lek u korpu preko sifra leka");
                                Console.WriteLine("2. Dodaj lek u korpu preko recepta");
                                Console.WriteLine("3. Prikazi sadrzaj korpe");
                                Console.WriteLine("4. Zavrsi kupovinu");
                                Console.WriteLine("Unesi bilo sta drugo da odustanak od kupovine");
                                int op = Convert.ToInt32(Console.ReadLine());
                                if (op == 1)
                                {
                                    Console.WriteLine("Unesi sifru leka");
                                    int sl = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Unesi kolicinu");
                                    int kol = Convert.ToInt32(Console.ReadLine());
                                    ukupnaCena +=lekKontroler.GetLek(sl).Cena*kol;
                                    racun.Lekovi.Add(lekKontroler.GetLek(sl), kol);
                                }
                                else if (op == 2)
                                {
                                    Console.WriteLine("Unesi sifru recepta");
                                    int sr = Convert.ToInt32(Console.ReadLine());
                                    Recept rec = receptKontroler.GetRecept(sr);
                                    foreach (KeyValuePair<Lek, int> par in rec.Lekovi)
                                    {
                                        racun.Lekovi.Add(par.Key, par.Value);
                                        ukupnaCena += par.Key.Cena * par.Value;
                                    }
                                }
                                else if (op == 3)
                                {
                                    foreach (KeyValuePair<Lek, int> par in racun.Lekovi)
                                    {
                                        Console.WriteLine(par.Key.ToString() + ", kolicina = " + par.Value);
                                    }
                                }
                                else if (op == 4)
                                {
                                    racun.Cena = ukupnaCena;
                                    lekKontroler.KreirajRacun(racun);
                                    Console.WriteLine("Cena porudzbine: " + ukupnaCena);
                                    Console.WriteLine("Uspesno kreiran racun");
                                    break;
                                }
                                else
                                {
                                    break;
                                }

                            }

                            //racunaj ukupnu cenu
                            break;
                        }
                    default:
                        {
                            return;
                        }
                }
            }
        }
    }
}
