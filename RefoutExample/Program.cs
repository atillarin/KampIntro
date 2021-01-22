using System;

namespace RefoutExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string ilan = "Satılık Monster";
            string ilan2 = "Satılık Lenovo";
            string ilan3;

            Ilanver(ilan); // 1 burada ilan değişkenini değil ilanın değerini gönderiyoruz.
            Console.WriteLine(ilan); // 3 buarada ilan değişkeninde değişiklik olmadığı için  Satılık Monster yazacak

            Ilanverref(ref ilan2); // 4 ref anahtarı ile gönderdiğimiz için değişkeni gönderdik.
            Console.WriteLine(ilan2); // değişkenin değeri değişmiş hali 

            Ilanverout(out ilan3); // out anahtarı ise değişkeni değersiz göndermemizi sağlıyor.

        }


        static void Ilanver(string ilan)
        {
            ilan += " ilanı";  // 2 yeni bir değişkene yukarda gönderdiğimiz değere ekleme yaparak atıyoruz.
            Console.WriteLine(ilan);
        }

        static void  Ilanverref (ref string ilan2)
        {
            ilan2 += " ilanı";  // değişkene ekleme yapıyoruz.
            Console.WriteLine(ilan2); 

        }

        static void Ilanverout(out string ilan3)
        {
            ilan3 = " ilanı";  // out anahtarında değer ataması zorunlu.
            Console.WriteLine(ilan3); 

        }
    }
}
