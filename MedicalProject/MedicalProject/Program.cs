using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedicalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            KorisnikKontroler korisnikKontroler = new KorisnikKontroler();
            LekKontroler lekKontroler = new LekKontroler();
            ReceptKontroler receptKontroler = new ReceptKontroler();

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
                            break;
                        }
                    case 2:
                        {
                            break;
                        }
                    case 3:
                        {
                            break;
                        }
                    case 4:
                        {
                            break;
                        }
                    case 5:
                        {
                            break;
                        }
                    case 6:
                        {
                            break;
                        }
                    case 7:
                        {
                            break;
                        }
                    case 8:
                        {
                            break;
                        }
                    case 9:
                        {
                            break;
                        }
                    case 10:
                        {
                            break;
                        }
                    default:
                        {
                            break;
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
                            break;
                        }
                    case 2:
                        {
                            break;
                        }
                    case 3:
                        {
                            break;
                        }
                    case 4:
                        {
                            break;
                        }
                    case 5:
                        {
                            break;
                        }
                    default:
                        {
                            break;
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
                            break;
                        }
                    case 2:
                        {
                            break;
                        }
                    case 3:
                        {
                            break;
                        }
                    case 4:
                        {
                            break;
                        }
                    case 5:
                        {
                            break;
                        }
                    case 6:
                        {
                            break;
                        }
                    case 7:
                        {
                            break;
                        }
                    case 8:
                        {
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
        }
    }
}
