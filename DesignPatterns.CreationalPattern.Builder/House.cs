using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPattern.Builder
{
    public class House
    {
        public bool HasWalls { get; set; }
        public bool HasDoors { get; set; }
        public bool HasWindows { get; set; }
        public bool HasRoof { get; set; }
        public bool HasGarage { get; set; }
        public bool HasSwimPool { get; set; }
        public bool HasStatues { get; set; }
        public bool HasGarden { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine("House Details:");
            Console.WriteLine($"Walls: {HasWalls}");
            Console.WriteLine($"Doors: {HasDoors}");
            Console.WriteLine($"Windows: {HasWindows}");
            Console.WriteLine($"Roof: {HasRoof}");
            Console.WriteLine($"Garage: {HasGarage}");
            Console.WriteLine($"Swimming Pool: {HasSwimPool}");
            Console.WriteLine($"Statues: {HasStatues}");
            Console.WriteLine($"Garden: {HasGarden}");
        }
    }

    
}
