using System;
using System.IO;

namespace InterfaceLabDevX
{
    class MobilePhone : IMobile, INotation
    {
        public bool PowerOn()
        {
            Console.WriteLine("Would you like to turn on the device? y : n");
            string answer = Console.ReadLine();

            if (answer != null && answer.ToLower() == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public void Save(string message)
        {
            string filePath = @"C:\Users\hphifer\source\repos\InterfaceLabDevX\InterfaceLabDevX\NotebookData.txt";
            StreamWriter sw = new StreamWriter(filePath);

            sw.WriteLine(message);
            sw.Close();

            Console.WriteLine("Your message has been saved");
        }

        public void TakeNote(string message)
        {
            
            Console.WriteLine($"Your note: {message} has been created.");
            Console.WriteLine("Would you like to save your message? y : n");
            string input = Console.ReadLine();

            if (input != null && input.ToLower() == "y")
            {
                Save(message);
            }
            else
            {
                Console.WriteLine("Alright, we will not keep your info");
            }
            
        }
    }
}