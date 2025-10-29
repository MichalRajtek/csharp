namespace Cvicenie_Polia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] numbers = new int[7];

            numbers[0] = 10;
            numbers[1] = 15;
            numbers[2] = 35;
            numbers[3] = 48;
            numbers[4] = 2;
            numbers[5] = 1;
            numbers[6] = 19;

            int sum = 0;  
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);

            /*int sum = 0;  
            foreach (var number in numbers)
            {
                sum += number;
            }
            Console.WriteLine(sum); */

            Console.WriteLine("Kolko cisiel chcete zadat?");
            int count = int.Parse(Console.ReadLine());

            int[] numbers = new int[count];
            //pomocou cyklu, ktoreho naplnime pole cisiel, cez Console.ReadLine
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Zadaj cislo:");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            //Spocitanie vsetkych cisiel v poli a vypiseme na konzolu
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            Console.WriteLine("Sucet:");
            Console.WriteLine(sum);


        }
    }
}
