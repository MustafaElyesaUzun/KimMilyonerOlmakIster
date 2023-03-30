namespace KimMilyonerOlmakIster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kim Milyoner Olmak İster");

            Console.WriteLine("İsim Giriniz: ");
            string isim = Console.ReadLine();
            Console.WriteLine("Soyisim Giriniz: ");
            string soyisim = Console.ReadLine();

            Console.WriteLine("\n1. Telefon Jokerinizi Giriniz: ");
            string telefonJoker1 = Console.ReadLine();
            Console.WriteLine("\n2. Telefon Jokerinizi Giriniz: ");
            string telefoJoker2 = Console.ReadLine();
            Console.WriteLine("\n3. Telefon Jokerinizi Giriniz: ");
            string telefonJoker3 = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Hoşgeldiniz " + isim + " " + soyisim);

            Console.WriteLine("Kuralları biliyor musunuz ?");
            char kuralCevap = char.Parse(Console.ReadLine());

            if (kuralCevap != 'E')
            {
                Console.WriteLine("Kurallar: ajsgjsagja");
            }

            Console.WriteLine("Hazır mısınız ?");
            char hazirCevap = char.Parse(Console.ReadLine());
            if (hazirCevap != 'E')
            {
                Console.WriteLine("Hazir olmanız bekleniyor.");
                Console.WriteLine("Hazır olduğunuzda Enter'a basınız.");
                Console.ReadLine();
            }


            bool seyirciHak = true, yuzdeHak = true, telefonHak = true;
            int kasa = 0;

            int soruNo = 1, odul, baraj;
            int seyirciYuzdeA, seyirciYuzdeB, seyirciYuzdeC, seyirciYuzdeD;
            bool gizleA, gizleB, gizleC, gizleD;
            string soru,a,b,c,d;
            string cevap;

            #region Soru Bilgileri

            soruNo = 1;
            soru = "\"Kızıl Gezegen\" genellikle hangisi için yapılan bir benzetme olur?";
            a = "Kripton";
            b = "Cyberton";
            c = "Mars";
            d = "Vulcan";
            cevap = c;
            odul = 1000;
            baraj = 0;

            seyirciYuzdeA= 80; seyirciYuzdeB=10;
            seyirciYuzdeC= 5; seyirciYuzdeD=5;

            gizleA= false; gizleB= false;
            gizleC= false; gizleD= false;
            #endregion


            

        }
    }
}