namespace Cvicenie_Cykly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine(1);
            Console.WriteLine(2);
            Console.WriteLine(3);
            Console.WriteLine(4);
            Console.WriteLine(5);
            Console.WriteLine(6);
            Console.WriteLine(7);
            Console.WriteLine(8);
            Console.WriteLine(9);
            Console.WriteLine(10);*/

            //Vypiste na konzolu cisla od 1 do 50
            /*for (int i = 0; i <= 50; i++) 
            {
                Console.WriteLine(i);
            }*/

            //Vypisanei na konzolu cisla od 100 do 0
            /*for (int i = 100; i >= 0; i--)
            {
                Console.WriteLine(i);
            }*/

            //Vypiste na konzolu cisla od 1 do 100
            /*int i = 0;
            while (i <= 100)
            {
                Console.WriteLine( i);
                i++;
            }*/

            //Pomocou nekonecneho cyklu, zistite ci uzivatel zadal
            //slovo "pozdrav" na vypisanie "Ahoj"
            //slovo "exit" na ukoncenie programu
            //ine slova sa ignoruju a kod pokrafcuje zistovanim slova
            /*while (true)
            {
                string input = Console.ReadLine();

                if (input == "pozdrav")
                {
                    Console.WriteLine("Ahoj");
                }
                else if (input == "exit")
                {
                    break;
                }
                else if (input == "koniec")
                {
                    break;
                }
            }*/


            //Cyklus v cykle, pre ukoncenie vnutorneho cyklu EXIT
            //pre ukoncenie vonkajsieho cyklu KONIEC
            /*while (true)
            {
                while (true)
                {
                    Console.WriteLine("Zadajte exit pre ukocenie:");
                    string input = Console.ReadLine();
                    if (input == "exit")
                    {
                        break;
                    }
                    Console.WriteLine("Michal");
                }

                Console.WriteLine("Zadajte koniec pre ukocenie:");
                string inputDva = Console.ReadLine();
                if (inputDva == "koniec")
                {
                    break;
                }
                Console.WriteLine("Igor");
            }*/

            /*Console.WriteLine("*");
            Console.WriteLine("**");
            Console.WriteLine("***");
            Console.WriteLine("****");
            Console.WriteLine("*****");
            Console.WriteLine("******");
            Console.WriteLine("*******");*/

            Console.WriteLine("Kolko riadkov?:");
            int countOfRows = int.Parse(Console.ReadLine());
            Console.WriteLine("Z akeho znaku sa ma robit trojuholnik?:");
            string triangleDesign = Console.ReadLine();
            Console.WriteLine();
            for (int i = 1; i <= countOfRows; i++)
            {
                string row = "";
                for (int j = 1; j <= i; j++)
                {
                    row += triangleDesign;
                }
                Console.WriteLine(row);
            }

        }
    }
}
