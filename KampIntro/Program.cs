using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            string kategoriEtiket = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemGirisYapmisMi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.45;


            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("azalış butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi");
            }


            if (sistemGirisYapmisMi == false)
            {
                Console.WriteLine("Profili göster");    
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }

            Console.WriteLine(kategoriEtiket);





        }
    }
}
