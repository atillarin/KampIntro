using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;

            //sayi1 in değeri  30 olur

            int[] sayilar1 = new int[] { 10,20,30};
            int[] sayilar2 = new int[] { 100,200,300};
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            // sayilar1[0]   999 olur.

            //     Stack               heap
            // 101/sayilar1            101/ [10,20,30]
            // 102/sayilar2            102/ [100,200,300]

            //sayilar1 = sayilar2;  bu atamadan sonra sayilar1 in adresi 102 olur.

        }
    }
}
