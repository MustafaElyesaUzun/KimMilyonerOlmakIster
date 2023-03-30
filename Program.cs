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
            string telefonJoker2 = Console.ReadLine();
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
            char cevap;

            #region Soru Bilgileri

            soruNo = 1;
            soru = "\"Kızıl Gezegen\" genellikle hangisi için yapılan bir benzetme olur?";
            a = "Kripton";
            b = "Cyberton";
            c = "Mars";
            d = "Vulcan";
            cevap = 'C';
            odul = 1000;
            baraj = 0;

            seyirciYuzdeA= 80; seyirciYuzdeB=10;
            seyirciYuzdeC= 5; seyirciYuzdeD=5;

            gizleA= false; gizleB= false;
            gizleC= false; gizleD= false;
            #endregion

            #region Soru Kalıbı
            
            bool jokerHak = seyirciHak || yuzdeHak || telefonHak;
            soruNoktasi:
            Console.Clear();
            Console.WriteLine(soruNo + "-)" + soru);
            Console.WriteLine("A) " + (!gizleA ? a : ""));
            Console.WriteLine("B) " + (!gizleB ? b : ""));
            Console.WriteLine("C) " + (!gizleC ? c : ""));
            Console.WriteLine("D) " + (!gizleD ? d : ""));

            yanitNoktasi:

            Console.WriteLine("Cevabınızı giriniz veya");
            if (jokerHak)
            {
                Console.WriteLine("Joker için J'ye,");
            }
            Console.WriteLine("Çekilmek için R'ye basınız: ");
            char secim = char.Parse(Console.ReadLine());


            if (secim == 'J')
            {
                if (!jokerHak)
                { 
                    Console.WriteLine("Joker hakkınız bitmiştir."); 
                    goto yanitNoktasi;                
                }

                Console.WriteLine("1-) " + (seyirciHak ? "Seyirci" : ""));
                Console.WriteLine("2-) " + (yuzdeHak ? "%50" : ""));
                Console.WriteLine("3-) " + (telefonHak ? "Telefon" : ""));
                Console.WriteLine("Şeçiminizi yapınız: ");
                int jokerCevap = int.Parse(Console.ReadLine());

                if (jokerCevap == 1)
                {
                    Console.WriteLine("A) %" + seyirciYuzdeA);
                    Console.WriteLine("B) %" + seyirciYuzdeB);
                    Console.WriteLine("C) %" + seyirciYuzdeC);
                    Console.WriteLine("D) %" + seyirciYuzdeD);
                    seyirciHak = false;
                }

                else if (jokerCevap == 2) 
                {
                    gizleB = true;
                    gizleD = true;


                    yuzdeHak = false;
                    goto soruNoktasi;
                }
                
                else if (jokerCevap == 3)
                {
                    Console.WriteLine("1-) " + telefonJoker1);
                    Console.WriteLine("1-) " + telefonJoker2);
                    Console.WriteLine("1-) " + telefonJoker3);
                    Console.WriteLine("Kimi aramak istersiniz? : ");
                    int telefonCevap = int.Parse (Console.ReadLine());
                    if (soruNo <= 7 || telefonCevap == 3) Console.WriteLine("Cevap kesinlikte " + cevap);
                    else if (soruNo == 2) Console.WriteLine("Emin Değilim. Ancak " + cevap + " veya A olduğunu düşünüyorum.");
                    else if (soruNo == 1) Console.WriteLine("Bilemedim. Üzgünüm");
                    telefonHak = false;
                }
                else Console.WriteLine("Bu joker daha önce kullanıldı.");

                goto yanitNoktasi;
            }
            else if (secim == 'R')
            {
                Console.WriteLine(kasa + " TL kazanacaksınız.");
                Console.WriteLine("Çekilmek istediğinize emin misiniz? : ");
                char cekilCevap = char.Parse (Console.ReadLine());

                if (cekilCevap == 'E')
                {
                    Console.WriteLine("Tebrikler, " + kasa + " TL kazandınız.");
                    Console.WriteLine("Oyun bitti.");
                    Environment.Exit (0);
                }
                goto soruNoktasi;
            }

            #endregion


        }
    }
}