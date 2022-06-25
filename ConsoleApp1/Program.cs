using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği 
            // do not repeat yourself - kendini tekrarlama
            // deger tutucu ,
             
            string kategoriEtiketi = "kategoriler";
            int kayıtlıOgrenci = 32000;
            double faizOranı = 1.45;
            bool sistemeGırısYapmısMı = true;
            double dolarDun = 7.45;
            double dolarBugün = 7.45;

            if (dolarDun > dolarBugün)
            {
                Console.WriteLine("azalış butonu");
            }

            else if (dolarBugün > dolarDun) 
            {
                Console.WriteLine("artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");

            }
           






            if (sistemeGırısYapmısMı==true)

            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }


            Console.WriteLine(kategoriEtiketi);
           
        }

    }
}
