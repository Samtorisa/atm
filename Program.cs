using System;
using System.Collections.Generic;
using System.Linq;

namespace bankApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            while (true)
            {
                Console.WriteLine("Yapmak istediğiniz işlemi seçiniz:");
                Console.WriteLine("1 Kullanıcı seç ve işlem yap");
                Console.WriteLine("2 Kullanıcı ekle");
                Console.WriteLine("0 Çıkış");
                string process1 = Console.ReadLine();

                if (process1 == "0")
                {
                    Console.WriteLine("Programdan çıkılıyor...");
                    break; // Döngüden çıkılır
                }
                else if (process1 == "1")
                {
                    if (persons.Count <= 0)
                    {
                        Console.WriteLine("Kullanıcı bulunmuyor. Önce bir kullanıcı ekleyin.");
                        continue; 
                    }

                    Console.WriteLine($"Kullanıcı sayısı = {persons.Count}. Aşağıda kullanıcılar listelenmiştir. Kullanıcının ID'sini girerek işlem yapmaya devam edebilirsiniz.");
                    foreach (Person person in persons)
                    {
                        Console.WriteLine($"{person.Id} - {person.Name} {person.SurName}");
                    }

                    int personId = int.Parse(Console.ReadLine());

                    bool exist = persons.Any(x => x.Id == personId);
                    if (exist)
                    {
                        Person person = persons.Find(x => x.Id == personId);
                        Console.WriteLine($"Hoşgeldiniz {person.Name} {person.SurName}. Aşağıdaki işlemlerden birini seçerek işlem yapabilirsiniz.");

                        Console.WriteLine("1 Para çek");
                        Console.WriteLine("2 Para yükle");

                        string process2 = Console.ReadLine();
                        if (process2 == "1")
                        {
                            Console.WriteLine("Para miktarını giriniz:");
                            int amount = int.Parse(Console.ReadLine());
                            try
                            {
                                person.withDrawMoney(amount);
                                Console.WriteLine($"Para çekme işlemi başarılı. Yeni bakiye = {person.Balance}");
                            }
                            catch (Exception e) { Console.WriteLine(e.ToString()); continue; }
                        }
                        else if (process2 == "2")
                        {
                            Console.WriteLine("Para miktarını giriniz:");
                            int amount = int.Parse(Console.ReadLine());
                            try
                            {
                                person.addMoney(amount);
                                Console.WriteLine($"Para çekme işlemi başarılı. Yeni bakiye = {person.Balance}");
                            }
                            catch (Exception e) { Console.WriteLine(e.ToString()); continue; }
                        }
                    }
                    else
                    {
                        Console.WriteLine("böyle bir kullanıcı mevcut değil");
                    }
                }
                else if (process1 == "2")
                {
                    Person person = new Person();
                    Console.WriteLine("Kullanıcı adı giriniz:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Kullanıcı soyadı giriniz:");
                    string surName = Console.ReadLine();
                    person.Name = name;
                    person.SurName = surName;
                    person.AddNewPerson(persons, person);
                }
                else
                {
                    Console.WriteLine("Geçersiz işlem seçimi. Lütfen tekrar deneyin.");
                }
            }
        }
    }
}
