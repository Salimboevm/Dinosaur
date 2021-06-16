using System;
using System.Collections.Generic;
using System.Text;

namespace Dinosaurs
{
    class Display
    {
        string name;
        string sex;
        bool canFly;
        int age;
        public Display()
        {
            //Display the first time running text
            Console.WriteLine("This is the first time the program is running...." );
            Console.WriteLine("You will only see this message once when the program is launched!");
            Console.WriteLine("");
        }
        public static void MainMenu()
        {
            //give the user information about the classes and ask choosing one of them
            Console.WriteLine("Please Choose:");
            Console.WriteLine("1. Create a main character");
            Console.WriteLine("2. Display character details");
            Console.WriteLine("3. Add Dinosaur");
            Console.WriteLine("4. Display all dinosaur details");
            Console.WriteLine("5. Save");
            Console.WriteLine("6. Load");
            Console.WriteLine("7. Exit");
            Console.WriteLine();
        }
        /// <summary>
        /// functionto create new dinosaur
        /// </summary>
        public void CreateNew()
        {
            Console.WriteLine("Dinosaur Creation:");
            Console.WriteLine("");

            string n = Name();
            string g = Gender();
            bool f = Fly();
            int a = Age();
            
            Console.WriteLine("");

        }
        /// <summary>
        /// function to display information about the dinosaur
        /// </summary>
        public void DisplayInfo()
        {
            Console.WriteLine("Information about dinosaur: ");
            Console.WriteLine("");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Gender: " + sex);
            Console.WriteLine("Can Fly: " + canFly);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("");
        }
        /// <summary>
        /// function to add dinosaur to the list
        /// </summary>
        /// <returns></returns>
        public Dinosaur AddDinosaur()
        {
            Dinosaur dinosaur = new Dinosaur(name,sex,canFly,age);
            Reset();
            return dinosaur;
        }
        /// <summary>
        /// function to reset variables
        /// </summary>
        private void Reset()
        {
            name = "";
            sex = "";
            canFly = false;
            age = 0;
        }
        //set name
        private string Name()
        {
            Console.WriteLine("Please enter the name: ");
            name = Console.ReadLine();
            Console.WriteLine("");
            return name;
        }
        //set gender
        private string Gender()
        {
            Console.WriteLine("Please enter the gender of your Dinosaur: ");
            sex = Console.ReadLine();
            Console.WriteLine("");
            return sex;
        }
        //set type
        private bool Fly()
        {
            Console.WriteLine("Can your dino fly?: (Y/N)");
            string temp = Console.ReadLine();
            Console.WriteLine("");
            if (temp == "Y" || temp == "y")
                return canFly = true;
            else
                return canFly = false;
        }
        //set age
        private int Age()
        {
            Console.WriteLine("In which period is your dinosaur lived/living: (Please enter the number)");
            age = Convert.ToInt32(Console.ReadLine());
            return age;
        }
        //
    }
    
}
