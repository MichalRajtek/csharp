using System.Data;

namespace Cvicenie_StringMath
{
    class Program
    {
        static void Main()
        {
            // Zoznam ľudí:
            var people = new List<string>
        {
            "Adam", "Beáta", "Cyril", "Daniela", "Eva", "František", "Gabriel", "Hana", "Igor", "Jana",
            "Kamil", "Lenka", "Martin", "Norbert", "Oľga", "Patrik", "Roman", "Simona", "Tomáš", "Viera",
            "Zuzana", "Alex", "Barbora", "Cecília", "David", "Edita", "Filip", "Gustáv", "Henrieta", "Ivana",
            "Jakub", "Kristína", "Lukáš", "Mária", "Natália", "Ondrej", "Petra", "Renáta", "Stanislav", "Tereza",
            "Veronika", "Zdeněk", "Aneta", "Branislav", "Dagmar", "Dominik", "Emília", "Ferdinand", "Gabriela", "Horst"
            // Pridaj ďalšie mená podľa potreby
        };

            var selected = RandomSelectPeople(people, 20);

            Console.WriteLine("Náhodne vybraných 20 ľudí:");
            foreach (var name in selected)
            {
                Console.WriteLine(name);
            }
        }

        // Metóda na náhodný výber n ľudí zo zoznamu (bez opakovania)
        static List<string> RandomSelectPeople(List<string> people, int n)
        {
            if (n > people.Count)
                throw new ArgumentException("Počet vybraných je väčší ako počet ľudí v zozname!");

            var rand = new Random(1445577);
            var peopleCopy = new List<string>(people); // aby sme nemiešali originál
            var result = new List<string>();

            for (int i = 0; i < n; i++)
            {
                int idx = rand.Next(peopleCopy.Count);
                result.Add(peopleCopy[idx]);
                peopleCopy.RemoveAt(idx);
            }
            return result;
        }
    }
}
