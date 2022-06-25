using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştirici kursu";
            string kurs2 = "programlamlama";
            string kurs3 = "java";
            string kurs4 = "c#";

            //onsole.WriteLine(kurs1);
            //Console.WriteLine(kurs2);               
            //Console.WriteLine(kurs3);

            //array - dizi 

            string[] kurslar = new string[] { kurs1, kurs2, kurs3, kurs4 }; 

            //kurslar.Length - ne kadar eleman varsa

            for (int i = 0; i<kurslar.Length; i++)  
            {
                Console.WriteLine(kurslar[i]);  
            }

            Console.WriteLine("forbitti");

            foreach (string kurs in kurslar ) // dizi temelli yapıları tek tek döner - kursları dolaş- dizilere uygulanır

            {
                Console.WriteLine(kurs);    

            }





            Console.WriteLine("sayfa sonu");
            Console.ReadLine(); 
        }
    }
}
