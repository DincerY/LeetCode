using System;

namespace DynamicProgramingExample
{
    class DinamikProgramlama
    {
        

        static int DinamikSayisi = 0; //counter atadik
        static int RecursiveSayisi = 0; //counter atadik
        static int SayiDegeri = 0;

       

     

        public static void Main()
        {
            DinamikProgramlama programNesnesi = new DinamikProgramlama(); //nesne olusturduk
            SayiDegeri = Convert.ToInt32(Console.ReadLine()); //sayi degerini kullanicidan aldik
            Console.WriteLine(FibonacciDinamikProgramlama(SayiDegeri));
            Console.WriteLine((SayiDegeri));
            Console.WriteLine(
                "Dinamik Programlama Çalisma Sayisi " + DinamikSayisi + "nRecursive fynksiyonun çalisma sayini " +
                RecursiveSayisi);
        }

    

  

        public static int FibonacciDinamikProgramlama(int SayiDegeri) //fonksiyon olusturduk
        {
            DinamikSayisi++;
            int[] SayilarDizisi = new int[SayiDegeri + 2];
            for (int i = 0; i <= SayiDegeri; i++)
                if (i == 0 || i == 1)
                {
                    SayilarDizisi[0] = 0;
                    SayilarDizisi[1] = 1;
                }
                else
                {
                    SayilarDizisi[i] = SayilarDizisi[i - 1] + SayilarDizisi[i - 2];
                }

            return SayilarDizisi[SayiDegeri];
        }

        public static int RecursiveFiboniacciFonksiyonu(int SayiDegeri)
        {
            RecursiveSayisi++;
            if (SayiDegeri == 0)
                return 0;
            if (SayiDegeri <= 2)
                return 1;
            return RecursiveFiboniacciFonksiyonu(SayiDegeri - 1) + RecursiveFiboniacciFonksiyonu(SayiDegeri - 2);
        }

    
    }
}