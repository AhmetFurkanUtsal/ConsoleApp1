using System;

namespace denemeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ogrenci ogrenci1 = new ogrenci();
            ogrenci1.adSoyad = "furkan";
            ogrenci1.ogrenciNo = "56";
            ogrenci1.not = "100";

            ogrenci ogrenci2 = new ogrenci();
            ogrenci2.adSoyad = "ahmet";
            ogrenci2.ogrenciNo = "80";
            ogrenci2.not = "19";


            ogrenci[] ogrenciler = new ogrenci[] { ogrenci1, ogrenci2 };

            foreach (var ogrenci in ogrenciler)
            {
                Console.WriteLine(ogrenci.adSoyad + ":" + ogrenci.ogrenciNo);
            }

            Console.ReadLine();
        }
    }
}

class ogrenci
{
    public string ogrenciNo { get; set; }
    public string adSoyad { get; set; }

    public string not { get; set; }





}