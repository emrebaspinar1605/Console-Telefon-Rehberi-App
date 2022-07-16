using System;
using System.Collections;
using System.Collections.Generic;

namespace telefonapp
{
    class Program
    {
        static void Main(string[] args)
        {
         IPhone iphone = new IPhone(); 
          List<Rehber> rehbers=new List<Rehber>();
            rehbers.Add(new Rehber("Osman","Yurttaşş","05084577414"));
            rehbers.Add(new Rehber("Enes","Canlı","05748563212"));
            rehbers.Add(new Rehber("Gökhan","Balık","05357971540"));
            rehbers.Add(new Rehber("Nadir","Parça","05055554142"));
            rehbers.Add(new Rehber("Emre","Başpınar","05077975555"));

          Console.WriteLine("Lütfen Yapmak istediğiniz işlemi seçiniz :)");
          Console.WriteLine("******************************************");
          Console.WriteLine("1.Telefon Numarası Kaydet");
          Console.WriteLine("2.Telefon Numarası Sil");
          Console.WriteLine("3.Telefon Numarası Güncelle");
          Console.WriteLine("4.Rehber Listeleme(A-Z,Z-A)");
          Console.WriteLine("5.Rehberde Arama");
          
          int print=int.Parse(Console.ReadLine());
          if (print>0 && print<6)
          {
            switch (print)
            {
              case 1:
                
                iphone.SaveNumber();
                break;

              case 2:
                iphone.Delete();
                break;

              case 3:
                iphone.UpdateNumber();
                break;

              case 4:
                iphone.GetList();
                break;
              
              case 5:
                iphone.Search();
                break;
            }
          }
          else 
          {
            Console.WriteLine("Lütfen 1'den 5'e kadar bir rakam giriniz");
          }
        } 
    }
}