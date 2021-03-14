using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            int vize, final, ort;
            string ad_soyad, tc_no;
            Console.Write("Ogrencinin TC Kimlik numarasini giriniz: ");
            tc_no = Console.ReadLine();
            if ((tc_no.Length < 11) || (tc_no.Length > 11))
            {
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {
                    Console.WriteLine("TC Kimlik numarasi 11 haneden kucuk veya buyuk olamaz!!");
                }
            }
            Console.Write("Ogrencinin adini ve soyadini giriniz: ");
            ad_soyad = Console.ReadLine();
            if ((ad_soyad == ""))
            {
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {
                    Console.WriteLine("Ad Soyad bilgisi Bilgisi girilmek zorundadir.");
                }
            }
            Console.Write("Ogrencinin vize notunu giriniz: ");
            vize = Convert.ToInt16(Console.ReadLine());
            if ((vize < 0) || (vize > 100))
            {
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {
                    Console.WriteLine("Notlar 0'dan Kucuk veya 100'den Buyuk olamaz");
                }
            }
            Console.Write("Ogrencinin final notunu giriniz: ");
            final = Convert.ToInt16(Console.ReadLine());
            if ((final < 0) || (final > 100))
            {
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {
                    Console.WriteLine("Notlar 0'dan Kucuk veya 100'den Buyuk olamaz ");
                }
            }
            ort = (int)(vize * 0.4 + final * 0.6);
            Console.WriteLine("\n {0} Numarali {1}'in Ortalamasi: {2}", tc_no, ad_soyad, ort);

        }
    }
}
