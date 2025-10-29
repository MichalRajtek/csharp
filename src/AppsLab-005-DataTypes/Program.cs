using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*bool isAdult = true;
            Console.WriteLine(isAdult);

            int myAge = 29;
            Console.WriteLine(myAge);

            float pi = 3.14f;
            Console.WriteLine(pi);

            string name = "Michal";
            Console.WriteLine(name);

            char gender = 'M';
            Console.WriteLine(gender);
            */

            int a = 10;
            int b = 2;

            int sum = a + b;
            //Scitavanie cisla A a B
            //Console.WriteLine(sum);
            Console.WriteLine(a + b);
            //Console.WriteLine(10 + 5);

            //Odcitavanie cisla A a B
            Console.WriteLine(a - b);

            //Nasobe cisla A a B
            Console.WriteLine(a * b);

            //Delenie cisla A a B
            Console.WriteLine(a / b);

            Console.WriteLine("Volam sa Michal");



            int birthDay = 6;
            int birthMonth = 12;
            int birthYeart = 1996;

            //Scitanie datumu narodenia a mesiaca a roku  do premennej birthSum
            int birthSum = birthDay + birthMonth + birthYeart;
            //Vypisanie na konzolu birthSum (cez Console.WriteLine)
            Console.WriteLine(birthSum);
            //Nasledne vynasobte birthSu * 10 a vypiste nasobok
            Console.WriteLine(birthSum * 10);


            //Scitajte datum narodenia a mesiac a az potom prenasobte rokom
            //6 + 12 * 1996 = 35,928
            Console.WriteLine((birthDay + birthMonth) * birthYeart);

            //Problem s int a float 
            Console.WriteLine(5 / 3);
            Console.WriteLine(5f / 3f);


            //Vytvorte si premennu s vasim meno a scitajte ju s rokom narodenia
            string myName = "Michal";
            Console.WriteLine(myName + birthYeart);

            //Vypiste meno a sucet dna a mesiaca narodenia
            Console.WriteLine(myName + (birthDay + birthMonth));

            bool result = 6 >= 8;
            Console.WriteLine(result);


            int krabickaA = 10;
            int krabickaB = krabickaA;
            krabickaA = 6;
            Console.WriteLine(krabickaA == krabickaB);
        }
    }
}