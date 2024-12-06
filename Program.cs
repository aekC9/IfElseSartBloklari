using System;
namespace IfElseSartBloklari;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("İsim Soyisim: ");
        string FullName = Console.ReadLine();
        Console.Write("Matematik dersinden aldığınız notu giriniz: ");
        int matNot = int.Parse(Console.ReadLine());
        Console.Write("Fizik dersinden aldığınız notu giriniz:");
        int fizNot = int.Parse(Console.ReadLine());
        Console.Write("Edebiyat dersinden aldığınız notu giriniz: ");
        int edbNot = int.Parse(Console.ReadLine());
        double sinavNotu = Convert.ToDouble((matNot + fizNot + edbNot) / 3);
        if(sinavNotu<70)
        {
            Console.WriteLine($"Sevgili {FullName}, maalesef barajı geçemediniz bidahaki sefere dersinizi iyi çalışmanızı tafsiye ederim, not ortalamanız {sinavNotu}");
        }
        else 
        {
            Console.WriteLine($"Sevgili {FullName}, tebrikler barajı geçtiniz, başarılarınız devamını dileriz, not ortalamanız {sinavNotu}");
        }
    }
}
