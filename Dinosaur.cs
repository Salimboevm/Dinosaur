using System;
using System.Collections.Generic;
using System.Text;

namespace Dinosaurs
{
    /// <summary>
    /// info about dinosaur
    /// </summary>
    class Dinosaur
    {
        private string name;//name of dinosaur
        private string sex;//gender of dinosaur
        private bool classification;//type of dinosaur
        private int period;//age of dinosaur

        /// <summary>
        /// constructor to set dinosaur
        /// </summary>
        /// <param name="name"></param>
        /// <param name="sex"></param>
        /// <param name="classification"></param>
        /// <param name="period"></param>
        public Dinosaur(string name,string sex,bool classification, int period)
        {
            this.Name = name;//set name
            this.Sex = sex;//set gender
            this.Classification = classification;//set type
            this.Period = period;//set age
        }
        #region Properties
        public string Name { get => name;private set => name = value; }
        public string Sex { get => sex;private set => sex = value; }
        public bool Classification { get => classification;private set => classification = value; }
        public int Period { get => period;private set => period = value; }
        #endregion
        /// <summary>
        /// function that displays info about dinosaur
        /// </summary>
        public void DisplayInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Gender: " + Sex);
            Console.WriteLine("Can fly: " + Classification);
            Console.WriteLine("Age: " + Period);
        }
        #region Setters
        public string SetName(string name)
        {
            return this.name = name;
        }
        public string SetGender(string gender)
        {
            return sex = gender;
        }
        public bool SetType(bool type)
        {
            return classification = type;
        }
        public int SetAge(int age)
        {
            return period = age;
        }
        #endregion
    }
}
