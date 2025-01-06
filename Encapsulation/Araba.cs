using System;

namespace Encapsulation
{
    public class Araba
    {
        // Public property'ler
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }

        // Private alan
        private int _kapiSayisi;

        // Encapsulated property
        public int KapiSayisi
        {
            get { return _kapiSayisi; }
            set
            {
                if (value == 2 || value == 4)
                {
                    _kapiSayisi = value;
                }
                else
                {
                    Console.WriteLine("Uyarı: Kapı sayısı yalnızca 2 veya 4 olabilir! Varsayılan olarak -1 atanıyor.");
                    _kapiSayisi = -1;
                }
            }
        }

        // Constructor
        public Araba(string marka, string model, string renk, int kapiSayisi)
        {
            Marka = marka;
            Model = model;
            Renk = renk;
            KapiSayisi = kapiSayisi; // Kapsülleme kontrolü yapılır
        }
    }
}