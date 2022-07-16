using System;
using System.Collections.Generic;

namespace telefonapp
{
    public class IPhone
    {
        List<Rehber> rehbers=new List<Rehber>();
      public void SaveNumber()
       {
        Console.Clear();
        
        Rehber rehber1 = new Rehber();
        int func1 = 2;
        while (func1 == 2)
        {
            
        
        Console.WriteLine(" (1) Yeni Numara Kaydetme Işlemi ");
        Console.WriteLine(" Lütfen isim Giriniz                          :");
        rehber1.Name = Console.ReadLine();
        Console.WriteLine(" Lütfen Soyadınızı giriniz                    :");
        rehber1.SurName = Console.ReadLine();
        Console.WriteLine(" Lütfen Telefon Numaranızı giriniz            :");
        rehber1.Tel = Console.ReadLine();

        rehbers.Add(rehber1);
        Console.WriteLine(" Kişi rehbere eklendi");
        Console.WriteLine(" Eklenen Son Kişinin Bilgiler...");
        Console.WriteLine(rehbers[rehbers.Count-1].Name);
        Console.WriteLine(rehbers[rehbers.Count-1].SurName);
        Console.WriteLine(rehbers[rehbers.Count-1].Tel);
        
        Console.WriteLine(" Devam etmek istiyorsanız 2,İstemiyorsanız Herhangi bir Tuşa basınız ");
        var contunie = Console.ReadLine();
        bool isContunie=int.TryParse(contunie,out int repeat);
        repeat=func1;
        }
       }

        public void Delete()
       {
        Console.Clear();
        string nameOrSurname;
        int continueToDelete = 2;
        while (continueToDelete==2)
        {
            Console.Write(" Lütfen Numarası Silinmesini istediğiniz kişinin adını yada Soyadını giriniz:");
            nameOrSurname = Console.ReadLine().ToLower();
            foreach (var rehber in rehbers)
            {
                string lowerName=rehber.Name.ToLower();
                string lowerSurName=rehber.SurName.ToLower();
                if ((rehbers.IndexOf(rehber) == rehbers.Count-1) && ! (nameOrSurname == lowerName || nameOrSurname == lowerSurName))
                {
                      Console.WriteLine(" Aradığınız krtiterlere uygun veri bulunamadı. Lütfen bir seçim yapınız.");
                      Console.WriteLine(" * Silmeyi sonlandırmak için : (1)"); 
                      Console.WriteLine(" * Yeniden denemek için      : (2)");
                      continueToDelete = Convert.ToInt32(Console.ReadLine());
                    

                }
                else if( nameOrSurname == lowerName || nameOrSurname == lowerSurName)
                {
                    Console.WriteLine(rehber.Name +" "+rehber.SurName+" : "+rehber.Tel+" kişi rehberden silinsin mi?(y/n");
                    char onay=Convert.ToChar(Console.ReadLine());
                    if (onay=='y')
                    {
                         Console.WriteLine(rehber.Name +" "+rehber.SurName+" : "+rehber.Tel+" kişi  silindi");
                        rehbers.RemoveAt(rehbers.IndexOf(rehber));
                        continueToDelete = 1;
                        break;
                    }
                    else
                    {
                        Console.WriteLine(" İşleme Devam Etmek ister misini?(y/n)");
                        char yn=Convert.ToChar(Console.ReadLine());
                        if(yn=='y')
                        {
                            continueToDelete=2;
                        }
                        else
                        {
                            continueToDelete=1;
                            break;
                        }
                    }
                }
            }
        }
       }

       public void GetList()
       {
        List<Rehber> rehbers= new List<Rehber>();
        Console.WriteLine(" Telefon Rehberi");
        Console.WriteLine(" **********************************************");
        rehbers.Sort();
        Console.WriteLine("A-Z Şeklinde Olan Sıralama");
        foreach (var rehber in rehbers)
        {
            Console.WriteLine(" isim: {"+rehber.Name+"}");
            Console.WriteLine(" Soyisim: {"+rehber.SurName+"}");
            Console.WriteLine(" Telefon Numarası: {"+rehber.Tel+"}");
            Console.WriteLine(" -");
        }
        rehbers.Reverse();
        Console.WriteLine("Z-A Şeklinde Olan Sıralama");
         foreach (var rehber in rehbers)
        {
            Console.WriteLine(" isim: {"+rehber.Name+"}");
            Console.WriteLine(" Soyisim: {"+rehber.SurName+"}");
            Console.WriteLine(" Telefon Numarası: {"+rehber.Tel+"}");
            Console.WriteLine(" -");
        }
       }

        public void Search()
        {    
            List<Rehber> rehbers=new List<Rehber>();
            IPhone phones=new IPhone();
            Console.WriteLine(" Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine(" **********************************************");
            Console.WriteLine();
            Console.WriteLine(" İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine(" Telefon numarasına göre arama yapmak için: (2)");
            int onay=int.Parse(Console.ReadLine());
            if (onay==1)
            {
                string nameOrSurname=Console.ReadLine().ToLower();
                Console.WriteLine(" Arama Sonuçlarınız:");
                Console.WriteLine(" **********************************************");
                foreach (var rehber in rehbers)
                {
                    if (nameOrSurname==rehber.Name.ToLower()|| nameOrSurname==rehber.SurName.ToLower())
                    {
                        Console.WriteLine(" isim: {"+rehber.Name+"}");
                        Console.WriteLine(" Soyisim: {"+rehber.SurName+"}");
                        Console.WriteLine(" Telefon Numarası: {"+rehber.Tel+"}");
                        Console.WriteLine(" -");
                    }
                }
            }
            else if (onay==2)
            {
                string tel=Console.ReadLine().ToLower();
                Console.WriteLine(" Arama Sonuçlarınız:");
                Console.WriteLine(" **********************************************");
                foreach (var rehber in rehbers)
                {
                    if (tel==rehber.Tel.ToLower())
                    {   
                        Console.WriteLine(" isim: {"+rehber.Name+"}");
                        Console.WriteLine(" Soyisim: {"+rehber.SurName+"}");
                        Console.WriteLine(" Telefon Numarası: {"+rehber.Tel+"}");
                        Console.WriteLine(" -");
                    }
                }

            }
            else
            {
                Console.WriteLine("Böyle Bir Seçenek Yok ");
            }
        }

        public void UpdateNumber()
        {
            List<Rehber> rehbers=new List<Rehber>();
            Console.WriteLine(" Lütfen numarasını Güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
            string stringControl = Console.ReadLine().ToLower();
            int controller = 2;
            while (controller == 2)
            {
                
            
                foreach (var rehber in rehbers)
                {
                    string lowerName = rehber.Name.ToLower();
                    string lowerSurName = rehber.SurName.ToLower();
                    if (stringControl == lowerName || stringControl == lowerSurName)
                    {
                        Console.Write(" Lütfen Yeni Numarayı Giriniz : {");
                        string newTel = Console.ReadLine();
                        Console.WriteLine("}");
                        rehber.Tel = newTel;
                        break;
                    }
                    else
                    {
                        Console.WriteLine(" Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                        Console.WriteLine(" * Güncellemeyi sonlandırmak için    : (1)");
                        Console.WriteLine(" * Yeniden denemek için              : (2)");
                        int onay=int.Parse(Console.ReadLine());
                        if (onay==1)
                        {
                            break;
                        }
                        else if (onay==2)
                        {
                            controller=2;
                            continue;
                        }
                    }
                }
            }
        }
        
    }
}