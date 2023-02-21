﻿namespace InventoryManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = "C:\\Users\\91788\\source\\repos\\InventoryManagement\\InventoryManagement\\Inventory.json";
            Fetchinventory fetchinventory = new Fetchinventory();
            InventoryDetails data = fetchinventory.Read(path);
            
            Console.WriteLine("Types of Rice: ");

            for (int i = 0; i < data.typesOfRice.Count; i++)
            {
                Console.WriteLine(data.typesOfRice[i].name);
                Console.WriteLine(data.typesOfRice[i].weight);
                Console.WriteLine(data.typesOfRice[i].price);

                

                Console.WriteLine("-------------------");
            }

            Console.WriteLine("Types of Pulses: ");
            for (int i = 0; i < data.typesOfPulses.Count; i++)
            {
                Console.WriteLine(data.typesOfPulses[i].name);
                Console.WriteLine(data.typesOfPulses[i].weight);
                Console.WriteLine(data.typesOfPulses[i].price);

               

                Console.WriteLine("-------------------");
            }

            Console.WriteLine("Types of Wheat: ");
            for (int i = 0; i < data.typesOfWheat.Count; i++)
            {
                Console.WriteLine(data.typesOfWheat[i].name);
                Console.WriteLine(data.typesOfWheat[i].weight);
                Console.WriteLine(data.typesOfWheat[i].price);

                
                Console.WriteLine("-------------------");
            }



        }
    }
}