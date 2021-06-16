using System;
using System.Collections.Generic;
using System.Text;

namespace Dinosaurs
{
    /// <summary>
    /// class to contain dinosaurs 
    /// </summary>
    class DinoList
    {
        public List<Dinosaur> dinosaurs = new List<Dinosaur>();//dinosaurs list to controle how many we heave

        private string name;
        private int age;
        private string description;
        /// <summary>
        /// function that implements dinosaur and adds it to list
        /// </summary>
        /// <param name="dinosaur">dinosaur object that will be added to the list</param>
        public void Implement(Dinosaur dinosaur)
        {
            dinosaurs.Add(dinosaur);
        }
        public void Mutator()
        {

        }
        /// <summary>
        /// function to get Information about the all of the dinosaurs
        /// </summary>
        public void GetInfo()
        {
            Console.WriteLine("You have " + dinosaurs.Count + " dinousaur(s)");
            for (int i = 0; i < dinosaurs.Count; i++)//loop through list
            {
                dinosaurs[i].DisplayInfo();//display information about the dinosaur
            }
            Console.WriteLine("");//empty space
        }
    }
}
