using Encapsulation;

class Program
{
    static void Main(string[] args)
    {
        // Geçerli kapı sayısı
        Araba araba1 = new Araba("Volkswagen", "Tiguan", "Kırmızı", 4);
        Console.WriteLine($"Marka: {araba1.Marka}, Model: {araba1.Model}, Renk: {araba1.Renk}, Kapı Sayısı: {araba1.KapiSayisi}");

        // Geçersiz kapı sayısı
        Araba araba2 = new Araba("BMW", "3 Serisi", "Siyah", 3);
        Console.WriteLine($"Marka: {araba2.Marka}, Model: {araba2.Model}, Renk: {araba2.Renk}, Kapı Sayısı: {araba2.KapiSayisi}");
    }
}
