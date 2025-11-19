using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_IdleFarmer
{
    public class Plant
    {
        public string PlantType { get; set; }
        public int TimeForHarvest { get; set; }
        public int TimeInGround { get; set; }
        public int Price { get; set; }

        public Plant(string plantType, int timeForHarvest, int price)
        {
            PlantType = plantType;
            TimeForHarvest = timeForHarvest;
            Price = price;
        }

        public override string ToString()
        {
            return $"{PlantType} {TimeInGround}/{TimeForHarvest}  ({Price}e)";
        }
    }
}
