using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Introduktion_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution lösning = new Solution();
            //lösning.Uppgift_1A();//
            //lösning.Uppgift_1B();//
            //lösning.Uppgift_1C();//
            //lösning.Uppgift_1D();//
            //lösning.Uppgift_2A();//
            //lösning.Uppgift_2B();//
            //lösning.Uppgift_3A();//
            //lösning.Uppgift_3B();//
            //lösning.Uppgift_3C();//
            //lösning.Uppgift_4A();//
            //lösning.Uppgift_4B();//
            //lösning.Uppgift_4C();//
            //lösning.Uppgift_5();//
            //lösning.Uppgift_6();//
            //lösning.Uppgift_7();//
            //lösning.Uppgift_9A();//
            //lösning.Uppgift_9B();//
            //lösning.Uppgift_10A();//
            //lösning.Uppgift4620_steg2();
            //lösning_Uppgift4620_steg3();
            //lösning.Uppgift4620_steg4();
            lösning.Uppgift4620_steg5();

        }
    }

    class Solution
    {
        public Solution()
        {
        }



        public void Uppgift_1A()
        {
            Console.WriteLine("Vad heter du?");
            string namn = Console.ReadLine();
            Console.WriteLine("hej " + namn + ", varmt välkommen!");
        }



        public void Uppgift_1B()
        {
            var bredd = 9.6;
            var höjd = 5.4;
            var area = bredd * höjd;
            Console.WriteLine("Bredd = " + bredd);
            Console.WriteLine("Höjd = " + höjd);
            Console.WriteLine("Area = " + area);
        }




        public void Uppgift_1C()
        {
            Console.WriteLine("Skriv triangelns bredd: ");
            var bredd = Console.ReadLine();
            double Bredd = Convert.ToDouble(bredd);
            Console.WriteLine("Skriv triangelns höjd: ");
            var höjd = Console.ReadLine();
            double Höjd = Convert.ToDouble(höjd);
            var area = (Bredd * Höjd) / 2;
            Console.WriteLine("Area = " + area);
        }






        public void Uppgift_1D()
        {
            Console.WriteLine("Skriv ett tal: ");
            var ett = Console.ReadLine();
            int Ett = Convert.ToInt32(ett);
            Console.WriteLine("Skriv ett till tal: ");
            var två = Console.ReadLine();
            int Två = Convert.ToInt32(två);
            var summa = Ett + Två;
            Console.WriteLine("Summan av talen är: " + summa);

        }






        public void Uppgift_2A()
        {
            Console.WriteLine("Gissa mitt favorittal: ");
            var gissning = Console.ReadLine();
            int Gissning = Convert.ToInt32(gissning);
            if (Gissning == 3)
            {
                Console.WriteLine("Du gissade rätt!");
            }
            else
            {
                Console.WriteLine("Tyvärr, du gissade fel");
            }
        }





        public void Uppgift_2B()
        {
            Random randomGenerator = new Random();
            int tärningsögon1 = randomGenerator.Next(1, 7);
            int tärningsögon2 = randomGenerator.Next(1, 7);
            Console.WriteLine(tärningsögon1 + " " + tärningsögon2);
            if (tärningsögon1 == tärningsögon2)
            {
                Console.WriteLine("Vinst!");
            }

            else
            {
                Console.WriteLine("förlust");
            }

        }




        public void Uppgift_3A()
        {
            int nummer = 1;
            while (nummer < 6)
            {
                Console.WriteLine(nummer);
                nummer++;
            }
        }



        public void Uppgift_3B()
        {
            int nummer = 5;
            while (nummer <= 20)
            {
                Console.WriteLine(nummer);
                nummer = nummer + 3;
            }
        }




        public void Uppgift_3C()
        {
            int nummer = 10;
            while (nummer >= 0)
            {
                Console.WriteLine(nummer);
                nummer--;
            }
        }




        public void Uppgift_4A()
        {
            for (int räknare = 1; räknare <= 5; räknare = räknare + 1)
            {
                Console.WriteLine(räknare);
            }
        }




        public void Uppgift_4B()
        {
            for (int i = 5; i <= 20; i = i + 3)
            {
                Console.WriteLine(i);
            }
        }




        public void Uppgift_4C()
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }




        public void Uppgift_5()
        {
            Console.WriteLine("Gissa på ett tal: ");
            var tal = Console.ReadLine();
            int hej = Convert.ToInt32(tal);


            while (hej != 15)
            {
                Console.WriteLine("Tyvärr, gissa igen: ");
                var t = Console.ReadLine();
                hej = Convert.ToInt32(t);
            }
            Console.WriteLine("Grattis");
        }




        public void Uppgift_6()
        {
            Random randomGenerator = new Random();
            int tärnett = randomGenerator.Next(1, 7);
            int tärntvå = randomGenerator.Next(1, 7);
            Console.WriteLine("tärning ett: " + tärnett);
            Console.WriteLine("tärning två: " + tärntvå);
            if (tärnett == tärntvå)
            {
                if (tärnett == 6)
                {
                    Console.WriteLine("Stor vinst!");
                }
                else
                {
                    Console.WriteLine("Liten Vinst");
                }
            }
            else
            {
                Console.WriteLine("ingen vinst");
            }

        }





        public void Uppgift_7()
        {
            int[] tal = new int[6];

            int x = 3;

            for (int i = 0; i < 6; i++)
            {

                tal[i] = x;
                x = x + 2;
            }

            foreach (int y in tal)
            {
                int z = y + 1;
                Console.WriteLine(z + ", ");
            }
        }





        public void Uppgift_9A()
        {
            Console.WriteLine("Vad är ditt namn?");
            string name = Console.ReadLine();
            string k = Agent(name);
            Console.WriteLine("" + k);

        }

        private string Agent(string namn)
        {
            string hej = ("Välkommen Agent " + namn + ". Ditt uppdrag är...");
            return hej;

        }




        public void Uppgift_9B()
        {
            Console.WriteLine("Skriv in ett tal: ");
            var Talett = Console.ReadLine();
            int taltvå = Convert.ToInt32(Talett);

            Console.WriteLine("Skriv in ett till tal: ");
            var Taltvå = Console.ReadLine();
            int talett = Convert.ToInt32(Taltvå);



            Console.WriteLine("Deras summa är: " + Addera(talett, taltvå));
        }

        private int Addera(int ett, int två)
        {
            int Summan = ett + två;
            return Summan;
        }




        public void Uppgift_9B2()
        {
            Console.WriteLine("Skriv in ett tal: ");
            var Talett = Console.ReadLine();
            int taltvå = Convert.ToInt32(Talett);

            Console.WriteLine("Skriv in ett till tal: ");
            var Taltvå = Console.ReadLine();
            int talett = Convert.ToInt32(Taltvå);

            Console.WriteLine("Skriv in ett till tal: ");
            var Taltre = Console.ReadLine();
            int taltre = Convert.ToInt32(Taltre);

            //Summan av de två första talen
            var Summa2 = Addera(talett, taltvå);
            int summa2 = Convert.ToInt32(Summa2);

            //Summan när jag adderar sista talet
            var Summa3 = Addera(summa2, taltre);
            int summa3 = Convert.ToInt32(Summa3);




            Console.WriteLine("Deras summa är: " + summa3);
        }

        private int Addera_2(int ett, int två)
        {
            int Summan = ett + två;
            return Summan;
        }





        public void Uppgift_10A()
        {
            string[] inköpslista = new string[10];
            Console.WriteLine("Vill du lägga till något i din inköpslista? j/n ");
            string svar = Console.ReadLine();
            int i = 0;

            //kan lägga till fler varor tills man svarar nej
            while (svar == "j")
            {
                Console.WriteLine("Vad vill du lägga till? ");

                //lägger till varan i listan
                string vara = Console.ReadLine();
                inköpslista[i] = vara;

                Console.WriteLine("Vill du lägga till något mer i din inköpslista? j/n ");
                svar = Console.ReadLine();

                //ändrar vilken plats i listan nästa vara ska hamna på
                i = i + 1;
            }

            //skriver ut inköpslistan
            Console.WriteLine("Din inköpslista: ");
            foreach (string sak in inköpslista)
            {
                //tar bort tomma platser från listan
                if (sak != null)
                {
                    Console.WriteLine(sak);
                }


            }

        }







        public void Uppgift_7_2()
        {
            int[] tal = new int[6];

            int x = 3;

            for (int i = 0; i < 6; i++)
            {

                tal[i] = x;
                x = x + 2;
            }

            foreach (int y in tal)
            {
                int z = y + 1;
                Console.WriteLine(z + ", ");
            }
        }






        public void Uppgift4620_steg2()
        {
            string[] frågor = new string[3];
            frågor[0] = "Vad heter Norges huvudstad? ";
            frågor[1] = "Vad heter Danmarks huvustad? ";
            frågor[2] = "Vad heter Finlands huvustad";


            string[] svar = new string[3];
            svar[0] = "oslo";
            svar[1] = "köpenhamn";
            svar[2] = "helsingfors";


            int i = 0;
            foreach (string fråga in frågor)
            {

                //Fråga och läs in svaret
                Console.WriteLine(fråga);
                string svaret = Console.ReadLine();

                //kolla om svaret är rätt
                if (svaret == svar[i])
                {
                    Console.WriteLine("Rätt!");
                }
                else
                {
                    Console.WriteLine("Fel");
                }

                //Ändra rätta svaret till nästa fråga
                i++;
            }
        }




        public void lösning_Uppgift4620_steg3()
        {
            List<string> frågor;
            frågor = new List<string>();
            frågor.Add("Vad heter Norges huvudstad? ");
            frågor.Add("Vad heter Danmarks huvudstad? ");
            frågor.Add("Vad heter Finlands huvudstad? ");

            List<string> rättsvar;
            rättsvar = new List<string>();
            frågor.Add("oslo");
            frågor.Add("köpenhamn");
            frågor.Add("helsingfors");

            int i = 0;
            foreach (string fråga in frågor)

                //Fråga och läs in svaret
                Console.WriteLine(fråga);
            string svar = Console.ReadLine();

            //kolla om svaret stämmer med det rätta svaret
            if (svar == rättsvar[i])
            {
                Console.WriteLine("Rätt!");
            }
            else
            {
                Console.WriteLine("Fel");
            }
            //ändra det rätta svaret inför nästa fråga
            i++;
        }


        /*
        class QuestionCard
        {
            public String fråga;
            public String svar;           
        }
        public void Uppgift4620_steg4()
        {
            
            List<QuestionCard> frågekort = new List<QuestionCard>();


            QuestionCard card1 = new QuestionCard();
            card1.fråga = "Vad heter Norges Huvudstad";
            card1.svar = "oslo";
            frågekort.Add(card1);

            QuestionCard card2 = new QuestionCard();
            card2.fråga = "Vad heter Finlands Huvudstad";
            card2.svar = "helsingfors";
            frågekort.Add(card2);


            QuestionCard card3 = new QuestionCard();
            card3.fråga = "Vad heter Sveriges Huvudstad";
            card3.svar = "stockholm";
            frågekort.Add(card3);

            foreach (QuestionCard f in frågekort)
            {
                Console.WriteLine(f.fråga);
                string s = Console.ReadLine().ToLower();
                if (s == f.svar)
                {
                    Console.WriteLine("Rätt!");
                }
                else
                {
                    Console.WriteLine("Fel");
                }
            }
        }
        */



        public void Uppgift4620_steg5()
        {
            List<QuestionCard> frågekort = new List<QuestionCard>();

            QuestionCard card1; 
            card1 = new QuestionCard("Vad heter Norges huvudtsad?", "oslo");
            frågekort.Add(card1);

            QuestionCard card2;
            card2 = new QuestionCard("Vad heter Finlands huvudtsad?", "helsingfors");
            frågekort.Add(card2);

            QuestionCard card3;
            card3 = new QuestionCard("Vad heter Sveriges huvudstad?", "stockholm");
            frågekort.Add(card3);

            QuestionCard card4;
            card4 = new QuestionCard("Vad heter Danmarks huvudstad?", "köpenhamn");
            frågekort.Add(card4);

            foreach (QuestionCard kort in frågekort)
            {
                Console.WriteLine(kort.GetQuestion());
                string gissning = Console.ReadLine().ToLower();
                if (kort.IsCorrect(gissning))
                {
                    Console.WriteLine("Rätt!");
                }
                else
                {
                    Console.WriteLine("Fel");
                }
            }






        }











    }
}


            
























      



        
        
        
         
        







    



    






















