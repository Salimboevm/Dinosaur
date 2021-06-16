using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace Dinosaurs
{
    
    /// <summary>
    /// class for save and load
    /// </summary>
    class SaveLoad
    {
        const string fileName = "List.txt";//main save file
        public static DinoList dinoList = new DinoList();//list of dinosaurs
        static int temp = 0;//temporary number of dinosaurs

        /// <summary>
        /// save function
        /// uses binary system
        /// </summary>
        public static void Save()
        {
            try
            {
                BinaryWriter streamWriter = new BinaryWriter(File.OpenWrite("Count"));//secondary file that saves only number of dinosaurs
                //Pass the filepath and filename to the sreamwriter

                using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(fileName, FileMode.OpenOrCreate)))//create file
                {
                    for (int i = 0; i < dinoList.dinosaurs.Count; i++)//loop through dinosaurs count
                    {
                        //save them
                        binaryWriter.Write(dinoList.dinosaurs[i].Name);
                        binaryWriter.Write(dinoList.dinosaurs[i].Sex);
                        binaryWriter.Write(dinoList.dinosaurs[i].Classification);
                        binaryWriter.Write(dinoList.dinosaurs[i].Period);
                        temp++;//increase number of dinosaurs
                    }
                    streamWriter.Write(temp);//save temp number
                    streamWriter.Close();//close file
                    binaryWriter.Close();//close file
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
        /// <summary>
        /// function to load data 
        /// </summary>
        /// <returns></returns>
        public static DinoList Load()
        {
            string name = "";//name of object
            string gender= "";//gender of object
            bool canFly = false;//type of object
            int age = 0;//age of object

            BinaryReader read = new BinaryReader(File.OpenRead("Count"));//open secondary file
            temp = read.ReadInt32();//read the number of dinosaurs
            //check for main file
            if (File.Exists(fileName))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))//open it 
                {
                    for (int i = 0; i < temp; i++)//loop through number of dinosaurs which saved previously
                    {
                        //load data
                        name = reader.ReadString();
                        gender = reader.ReadString();
                        canFly = reader.ReadBoolean();
                        age = reader.ReadInt32();
                        Dinosaur d = new Dinosaur(name, gender, canFly, age);//create new dino
                        dinoList.dinosaurs.Add(d);//add it to list

                    }
                }
               
            }
            read.Close();//close file
            
            File.Delete("Count");//delete secondary file
            temp = 0;//reset
            return dinoList;//return dino list

        }
    }
}
