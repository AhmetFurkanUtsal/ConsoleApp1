// See https://aka.ms/new-console-template for more information

using metotlar;

string urunAdi = "elma";
double fiyati = 15;
string aciklama = "kırmızı elma";

string[] meyveler = new string[] { };

urun urun1 = new urun();
urun1.Adi = "elma";
urun1.Fiyati = 15;
urun1.Aciklama = "kırmızı elma";

urun urun2 = new urun();
urun2.Adi = "karpuz";
urun2.Fiyati = 80;
urun2.Aciklama = "Diyarbakır karpuzu";

urun[] urunler = new urun[] {urun1,urun2 };


//type - safe ** tip güvenliği 
foreach (urun urun in urunler)
{

    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Fiyati);
    Console.WriteLine(urun.Aciklama);
    Console.WriteLine("*****************");


}
Console.WriteLine("*******metotlar*****************");


//instanace * örnek 
//encapsulation
SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);

sepetManager.Ekle2("armut", "Yeşil armut", 12,3);
sepetManager.Ekle2("elma", "Yeşil elma", 12,7);
sepetManager.Ekle2("karpuz", "kare karpuz", 12,78);