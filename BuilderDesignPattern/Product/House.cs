using System;
using System.Collections.Generic;

namespace BuilderDesignPattern.Product
{
    //The product that contains data
    public class House
    {
        public string Model { get; set; }
        public string FoundationType { get; set; }
        public string FloorType { get; set; }
        public string Frames { get; set; }
        public string RoofType { get; set; }
        public string WallType { get; set; }
        
        public List<string> Essentials { get; set; }
        public List<string> Finishings { get; set; }

        public House()
        {
            Essentials = new List<string>();
            Finishings = new List<string>();
        }

        public void ShowData()
        {
            Console.WriteLine(String.Format("Model      :{0}", Model));
            Console.WriteLine(String.Format("Foundation :{0}", FoundationType));
            Console.WriteLine(string.Format("Floor Type :{0}", FloorType));
            Console.WriteLine(string.Format("Frames Type:{0}", Frames));
            Console.WriteLine(string.Format("Roof Type  :{0}", RoofType));
            Console.WriteLine(string.Format("Wall Type  :{0}", WallType));
            Console.WriteLine(string.Format("Essentials :"));

            foreach (var Essential in Essentials)
            {
                Console.WriteLine(string.Format("    {0}", Essential));
            }

            Console.WriteLine(string.Format("Finishing :"));
            foreach (var Finishing in Finishings)
            {
                Console.WriteLine(string.Format("    {0}", Finishing));
            }
           
        }
    }
}
