using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_IdleFarmer
{
    internal class IdleFarmer
    {
        public Random RandomGenerator { get; set; } = new Random();
        public bool ContinueInGame { get; set; } = true;

        public List<Plant> Field { get; set; } = new List<Plant>();
        public List<Plant> Storage { get; set; } = new List<Plant>();

        public int Money { get; set; } = 18;
        public int PlantCost { get; set; } = 5;
        public int Day { get; set; }

        public void StartGame()
        {
            while (ContinueInGame)
            {
                EndDay();
                RenderField();
                WriteMenu();
                ActionAtTheEndOfDay();

                //SolveMath();
            }
        }
        public void RenderField()
        {
            Console.WriteLine("Field:");
            foreach (var plant in Field)
            {
                Console.WriteLine(plant);
            }
            Console.WriteLine();
        }
        public void WriteMenu()
        {
            Console.WriteLine($"Den: {Day}");
            Console.WriteLine($"Penazenka: {Money}e");
            Console.WriteLine($"Sklad: {Storage.Count}x");

            Console.WriteLine("Enter.Pre ukoncenia dna");
            Console.WriteLine($"1.Pridaj novu kvetinku ({PlantCost}e)");
            Console.WriteLine("2.Predaj vsetko");
            Console.WriteLine("3.Ukaz sklad");
            Console.WriteLine("9.Ukonci hru");
        }
        public void EndDay()
        {
            //1.Koniec dna, raslina vyrastie
            foreach (Plant plant in Field)
            {
                plant.TimeInGround++;
            }

            //2.Na konci dna skontrolujeme ci rastina uz neni zrela, ak hej zapametaj si ju v liste harvestedPlant
            List<Plant> harvestedPlants = new List<Plant>();
            foreach (Plant plant in Field)
            {
                if (plant.TimeInGround == plant.TimeForHarvest)
                {
                    harvestedPlants.Add(plant);
                }
            }

            //3.Odstran rastlinu z pola a pridaj do skladu
            foreach (Plant plant in harvestedPlants)
            {
                Storage.Add(plant);
                Field.Remove(plant);
                Console.WriteLine("Rastina dorastla: " + plant);
            }

            Day++;
        }
        public void AddPlantToField()
        {
            if (Money - PlantCost >= 0)
            {
                Money -= PlantCost;
                PlantCost++;
                Field.Add(new Plant("Plant", RandomGenerator.Next(10, 50), RandomGenerator.Next(5, 10)));
                Console.WriteLine("Kvetina bola kupena a zasadena");
            }
            else
            {
                Console.WriteLine("Nemas dost penazi na nakup sadenicky");
            }
        }
        public void SellAllPlants()
        {
            if (Storage.Count > 0)
            {
                var numberOfPlantsInStorage = Storage.Count;
                var priceForPlantInStorage = 0;
                foreach (var plant in Storage)
                {
                    priceForPlantInStorage += plant.Price;
                }
                var moneyForSale = priceForPlantInStorage * numberOfPlantsInStorage;
                Money += moneyForSale;
                Storage.Clear();
                Console.WriteLine($"Predalo {numberOfPlantsInStorage} za {moneyForSale}");
            }
            else
            {
                Console.WriteLine("Mas prazdni sklad, nemas co predat");
            }
        }
        public void ActionAtTheEndOfDay()
        {
            var answer = Int32.Parse("0" + Console.ReadLine());
            Console.Clear();
            switch (answer)
            {
                case 1:
                    AddPlantToField();
                    break;
                case 2:
                    SellAllPlants();
                    break;
                case 3:
                    ShowStorage();
                    break;
                case 9:
                    ContinueInGame = false;
                    break;
            }
        }
        public void ShowStorage()
        {
            Console.Clear();
            Console.WriteLine("Aktualny sklad");
            foreach (var plant in Storage)
            {
                Console.WriteLine(plant);
            }
            Console.WriteLine("Enter pre pokracovanie!");
            Console.ReadLine();
            Console.Clear();
        }
        public void SolveMath()
        {
            int a = RandomGenerator.Next(0, 3);
            int b = RandomGenerator.Next(0, 3);
            int result = a + b;
            Console.WriteLine($"Kolko je {a} + {b}");

            while (true)
            {
                int answer = int.Parse(Console.ReadLine());
                if (answer == result)
                {
                    Console.Clear();
                    return;
                }
                Console.WriteLine("Nespavne , skus to este raz:");
            }
        }
    }
}
