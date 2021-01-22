using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //string[] isimler = new string[] { "Engin","Murat","Kerem","Halil"};
            //Console.WriteLine(isimler[0]);
            //isimler[4] = "ilker"; bu komut çalışmaz, çünkü yukarda 4 elemanlı tanım yapılmış, 5. isim için yer yok
            // isimlerin adresini değiştirdik ve 6 elemanlı tanımladık.
            //isimler = new string[5];
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);


            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            

            Console.WriteLine(isimler2[0]);
            isimler2.Add("ilker");
            Console.WriteLine(isimler2[4]);


           
        }
    }
}
