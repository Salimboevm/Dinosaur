using System;

namespace Dinosaurs
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //boolean to exit from the programm
            bool exit = false;
            Display display = new Display();//menu to display. Choices for user
            DinoList dinoList = new DinoList(); //list of dinosaurs
            //loop until user`s choice is exit
            do
            {
                Display.MainMenu();//display first menu
                char menuSelection = Console.ReadKey(true).KeyChar;//get user input
                if (Char.IsDigit(menuSelection)) {//check for digit
                    Console.Clear();//clear console
                    switch (menuSelection)//choose menu
                    {
                        
                        case '1':
                            display.CreateNew();//create new dinosaur
                            break;
                        case '2':
                            display.DisplayInfo();//give information about the dinosaur
                            break;
                        case '3':
                            dinoList.Implement(display.AddDinosaur());//add created dinosaur to list
                            break;
                        case '4':
                            dinoList.GetInfo();//get information about all dinosaurs
                            break;
                        case '5':
                            SaveLoad.dinoList = dinoList;//set dinosaurs list 
                            SaveLoad.Save();//save game
                            break;
                        case '6':
                            SaveLoad.Load();//load game 
                            dinoList = SaveLoad.dinoList;//get dinosaurs list
                            break;
                        case '7':
                            exit = true;//exit from the game
                            break;
                    }
                }
            } while (!exit);
        }
    }
}
