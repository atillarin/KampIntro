using System;

namespace classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Atilla";

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.Egitmen = "Engin Demirog";
            kurs1.IzlenmeOrani = "68";

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = "64";

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Pyton";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = "80";

            Console.WriteLine(kurs1.KursAdi + "  " + kurs1.Egitmen);

            Console.WriteLine("Hello World!");

            // kurs arrayi tanımlama

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };

            foreach (var x in kurslar)
            {
                Console.WriteLine(x.KursAdi);
            }

        }
    }

    class Kurs
    {   //prop yaz çift tab
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public string IzlenmeOrani { get; set; }
    }

}
