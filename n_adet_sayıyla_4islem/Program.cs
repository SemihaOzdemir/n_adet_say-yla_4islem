using System;

namespace n_adet_sayıyla_4islem
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("n adet sayı ile 4 işlem örneği");

            Console.WriteLine("kaç adet sayı gireceksiniz?");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] sayi = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i + 1}. sayıyı giriniz");
                sayi[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("hangi işlemi yapmak istediğinizi seçiniz?");
            char islem = Convert.ToChar(Console.ReadLine());

            double sonuc = Islem(islem,sayi);

            Console.WriteLine($"işlem sonucunuz= {sonuc}");

            Console.ReadKey();



            /*double sayi1 = 0, sayi2 = 0;
            
            Console.Write("Birinci sayıyı giriniz:");
            sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz:");
            sayi2 = Convert.ToDouble(Console.ReadLine());

        
            Console.Write("Operatörlerinden(+,-,*,/) birini giriniz:");
            char islem2 = Convert.ToChar(Console.ReadLine());

            switch (islem2)
            {
                case '+':
                    Console.WriteLine("Toplam= {0}", (sayi1 + sayi2).ToString());
                    break;
                case '-':
                    Console.WriteLine("Fark= {0}", (sayi1 - sayi2).ToString());
                    break;
                case '*':
                    Console.WriteLine("Çarpım= {0}", (sayi1 * sayi2).ToString());
                    break;
                case '/':
                    Console.WriteLine("Bölüm= {0}", (sayi1 / sayi2).ToString());
                    break;
                
            }

            Console.ReadKey(); */

        }



        private static double Islem(char islem, params int[] sayi)
        {
            double sonuc = 0;
           

            for (int i = 0; i < sayi.Length; i++)
            {
               
                switch (islem)
                {
                    case '+':
                        sonuc += sayi[i];
                        break;
                    case '-':
                        sonuc -= sayi[i];
                        break;
                    case '*':
                        sonuc *= sayi[i];
                        break;
                    case '/':
                        sonuc /= sayi[i];
                        break;
                }

            }

            return sonuc;
        }
    }
}
