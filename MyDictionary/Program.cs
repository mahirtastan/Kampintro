using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> sozluk = new Dictionary<string, int>();

        sozluk.Add("Elma", 100);
        sozluk.Add("Armut", 150);   // Anahtar-değer çiftleri ekleme
        sozluk.Add("Muz", 200);

        
        int deger = sozluk["Elma"];                           // Bir anahtarın değerini almak
        Console.WriteLine("Elma'nın değeri: " + deger);

        
        sozluk["Armut"] = 175;
        Console.WriteLine("Armut'un güncellenmiş değeri: " + sozluk["Armut"]);   // Bir anahtarın değerini güncelleme

        
        foreach (KeyValuePair<string, int> kvp in sozluk)       // Tüm anahtar-değer çiftlerini döngü ile erişme
        {
            Console.WriteLine("Anahtar: " + kvp.Key + ", Değer: " + kvp.Value);
        }

        
        bool anahtarVarMi = sozluk.ContainsKey("Elma");     // Bir anahtarı kontrol etme
        Console.WriteLine("Elma anahtarı var mı? " + anahtarVarMi);

        
        sozluk.Remove("Muz");   // Bir anahtar-değer çiftini silme

        
        sozluk.Clear();   // Tüm anahtar-değer çiftlerini temizleme

        Console.ReadLine();
    }
}
