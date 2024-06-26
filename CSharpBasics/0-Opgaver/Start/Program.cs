﻿using System.ComponentModel.Design;

namespace Start
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej og Velkommen til starter opgaverne!");

            // Dette er vores Main() metode, den starter med programmet.
            // Det er vigtigt at kalde alle metoder som også skal køres ved opstart!

            VariablerOgOperatører();
            Conditionals();
            Arrays();
            LoopsMedArraysOgAndreDatatyper();
        }

        static void header(string opgavenavn) {
            Console.WriteLine("------------------------");

            Console.WriteLine($"Her starter opgave: {opgavenavn}");
            Console.WriteLine("");
        }
        static int randomnumber;
        static void VariablerOgOperatører()
        {
            header("VariablerOgOperatører");

            Console.WriteLine("1.Udskriv længden af strengen “C# Bogen Opgaver”");

            string streng = "C# Bogen Opgaver";

            Console.WriteLine(streng.Length);

            Console.WriteLine("2. Lav et program som skriver et tilfældigt tal ud i konsollen");

            int mindsteværdi = 0;
            int maximumværdi = 100;
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                randomnumber = random.Next(mindsteværdi, maximumværdi);
                //ligeellerulige();
            }



            Console.WriteLine("3. Skriv en variable ind i en streng ved brug af $-tegnet");

            string input = "Indsæt mig i en anden streng";

            //Console.WriteLine("Indsæt input herefter: " + input);
            Console.WriteLine($"Indsæt input herefter: {input}");
        }
        static int num;
        static int valgtTal;
        static bool lige;
        //static void ligeellerulige()
        //{
            //num = randomnumber;
            //if (num % 2 == 0)
            //{
            //    Console.WriteLine($"{num} er lige");
            //    lige = true;
            //}
            //else
            //{
            //    Console.WriteLine($"{num} er ulige");
            //    lige= false;
            //}
            //if (valgtTal == 0)
            //{
            //    
            //}
            //int valgtTal 
            //if (valgtTal != 0 & valgtTal % 5 == 0)
            //{
            //    Console.WriteLine($"{valgtTal} går op i 5");
            //    lige = true;
            //}
            //else
            //{
            //    lige = false;
            //    Console.WriteLine($"{valgtTal} går ikke op i 5");
            //}
        //}
        static void Conditionals()
        {
            header("Conditionals - If / Else statements");

            Console.WriteLine("1. I skal skrive et stykke kode som fortæller om et tal (int) er lige eller ulige");
            //se ligeellerulige

            Console.WriteLine("2. 1. I skal skrive et stykke kode som fortæller om 5 går op i det tal som i vælger (int). \n Hvis den går op i det skal i skrive: 5 går op i (det tal i har valgt)");

            //int valgtTal = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Det valgte tal: {valgtTal}");
            
            //ligeellerulige();

            //if (lige == true)
            //{
            //    Console.WriteLine($"{valgtTal} går op i 5");
            //}
            //if (lige == false)
            //{
            //    Console.WriteLine($"{valgtTal} går ikke op i 5");
            //}
            Console.WriteLine($"5 går op i{valgtTal}");
            Console.WriteLine("3. Lav opgave 2 igen, men i stedet for selv at vælge et tal skal i lave sådan at den selv vælger et tal mellem 0 og 100.");

            Console.WriteLine("4. Lav et program som fortæller jer hvilke af de her 3 tal der er størst.\r\n a = 25; b = 33; c = 12;");

            Console.WriteLine("5. Lav et program der fortæller hvor varmt det er ud fra en temperatur. Kategorierne er som følger:\r\n- Hvis det er 0° eller under, skal der skrives: Det er frostvejr\r\n- Hvis det er mellem 1° og 10°, skal der skrives: Det er meget koldt\r\n- Hvis det er mellem 11° og 20°, skal der skrives: Det er koldt\r\n- Hvis det er mellem 21° og 30°, skal der skrives: Det er normalt vejr\r\n- Hvis det er mellem 31° og 40°, skal der skrives: Det er varmt\r\n- Hvis det er 41° eller over, skal der skrives: Det er meget varmt");

            Console.WriteLine("6. Lav et program som omformer tal til ugedage ved brug af Conditionals, som eksempel nedenunder:\r\n    \r\n    Den 1. dag i ugen er mandag\r\n    \r\n    Den 2. dag i ugen er tirsdag \r\n    \r\n    Den 4. dag i ugen er Torsdag osv.");

        }
        static int højestetal = 0;
        static int højestetal2 = 0;
        static void Arrays()
        {
            header("Arrays");

            Console.WriteLine("1. Skriv “Viborg” i konsollen ved at trække den ud fra følgende array");

            List<string> byer1 = new List<string> { "Randers", "Viborg", "Aarhus", "København" };

            string viborg = byer1[1];
            Console.WriteLine(viborg);

            Console.WriteLine("2. Tilføj “Skive” til denne array");

            List<string> byer2 = new List<string> { "Randers", "Viborg", "Aarhus", "København" };

            //byer2.Append<string>("Skive");
            byer2.Add("Skive");
            string Skive = byer2[4];
            Console.WriteLine(Skive);

            Console.WriteLine("3. Erstat den værdi, uden at ændre direkte i listen, som ikke passer ind, så listen stemmer");

            List<int> talrække1 = new List<int> { 0, 1, 0, 3, 4, 5, 6 };

            //talrække1.Insert(2, 2);
            talrække1[2] = 2;

            Console.WriteLine(String.Join("",talrække1));

            Console.WriteLine("4. Skriv, i konsollen, den største værdi fra følgende liste. Selvfølgelig ikke manuelt");

            List<int> talrække2 = new List<int> { 1, 2, 3, 4, 11, 55, 99, 100 };

            int indexlængde = talrække2.Count;
            
            for (int i = 0; i <= indexlængde -1; i++)
            {
                int højestetal2 = Convert.ToInt32(talrække2[i]);
                if (højestetal2 > højestetal);
                {
                    højestetal = højestetal2;
                }
                if (i == indexlængde -1)
                {
                    højestetal2.ToString();
                    Console.WriteLine(højestetal2);
                }
            }

            Console.WriteLine("5. Sorter den her liste:");

            List<int> talrække3 = new List<int> { 0, 12, 0, 22, 300, 4, 5 };

            talrække3.Sort();
            talrække3.ForEach(Console.WriteLine);
            


            Console.WriteLine("6. Sorter den her liste i omvendt rækkefølge:");

            List<int> talrække4 = new List<int> { 0, 12, 0, 22, 300, 4, 5 };
            talrække4.Sort();
            talrække4.Reverse();
            talrække4.ForEach(Console.WriteLine);


        }
        static void LoopsMedArraysOgAndreDatatyper()
        {
            header("Loops med arrays og andre datatyper");

            Console.WriteLine("1. Lav et program som summere følgende liste, uden brug af Aggregat Funktioner: ");

            List<int> talrække1 = new List<int> { 0, 12, 0, 22, 300, 4, 5 };

            int tal1 = talrække1[0];
            for (int i = 0; i <= talrække1.Count; i++)
            {
                tal1 = tal1 + talrække1[i];
                
                if (i == talrække1.Count)
                {
                    tal1.ToString();
                    Console.WriteLine(tal1);
                }
            }
                Console.WriteLine("2. Lav et program som skriver alle værdierne i denne liste, ved brug af foreach: ");

            List<int> talrække2 = new List<int> { 0, 12, 0, 22, 300, 4, 5 };

            Console.WriteLine("3. Lav et program som returnere indexet af det højeste tal, altså giver dens placering i begge lister");

            List<int> talrække3 = new List<int> { 0, 12, 0, 22, 300, 4, 5, 12, 12, 212, 12 };
            List<int> talrække4 = new List<int> { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 122 };

            Console.WriteLine("4. Lav et program som tæller hvor mange gange 12, står i den her liste:");

            List<int> talrække5 = new List<int> { 0, 12, 0, 22, 300, 4, 5, 12, 12, 212, 12 };

            Console.WriteLine("5. Lav et program som tæller, hvor mange værdier som er positive i denne liste: (0 er ikke positiv i denne opgave)");

            List<int> talrække6 = new List<int> { 0, -12, 0, -22, -300, 4, 5, -12, 12, -212, 12 };

            Console.WriteLine("6. Lav et program som finder gennemsnittet af følgende liste og alle andre lister bestående af tal uden brug af Aggregat Funktioner:");
            Console.WriteLine(" Forventet svar: 132.5");

            List<int> talrække7 = new List<int> { 0, 12, 0, 22, 300, 4, 5, 1000, -50, 32 };

            Console.WriteLine("7. Lav et program som finder variansen af følgende liste og alle andre lister bestående af tal uden brug af Aggregat Funktioner:");

            List<int> talrække8 = new List<int> { 0, 12, 0, 22, 300, 4, 5, 1000, -50, 32 };

            Console.WriteLine("8. Lav et program, som skriver følgende i konsollen. \r\nDen her gang skal det være med et loop, som skrive linjerne enkeltvis. \r\nMan skal hurtig og let kunne ændre hvor mange linjer den skriver. \r\nMan skal bruge 2 loops til opgaven. ");

            Console.WriteLine("*\r\n**\r\n***\r\n**\r\n*");



        }
    }
}
