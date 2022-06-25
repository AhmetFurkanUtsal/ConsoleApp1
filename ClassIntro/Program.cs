using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string Adi = "Furkan";
            int yas = 36;

            kurs kurs1= new kurs();
            kurs1.KursAdi = "c#";                     //Class olarak tanımladık.tek class o alanları verdik
            kurs1.Egitmen = "ali";
            kurs1.IzlemeOrai = 40;


            kurs kurs2 = new kurs();
            kurs2.KursAdi = "c++";
            kurs2.Egitmen = "veli";
            kurs2.IzlemeOrai = 90;

            kurs kurs3 = new kurs();
            kurs3.KursAdi = "java";
            kurs3.Egitmen = "nec";
            kurs3.IzlemeOrai = 70;



            // Console.WriteLine(kurs1.KursAdi + ":" + kurs1.Egitmen);


            kurs[] kurslar = new kurs[] {kurs1, kurs2,kurs3};

            foreach (var kurs in kurslar )
            {
                Console.WriteLine(kurs.KursAdi+ ":" + kurs.Egitmen);
            }

            Console.WriteLine("hello world!");
            Console.ReadLine();
        }
    }

    class kurs
    {
        public string KursAdi { get; set; } 
        public string Egitmen { get; set; } 
        public int IzlemeOrai { get; set; } 

       
    }
}
