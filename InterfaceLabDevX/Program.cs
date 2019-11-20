using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace InterfaceLabDevX
{
    class Program
    {
        static void Main(string[] args)
        {
            string message;

            //Using the Notebook class
           Notebook noteBook = new Notebook();

           Console.WriteLine("Give me a message");

            message = Console.ReadLine();

            noteBook.TakeNote(message);


            //Using the Computer class
            Computer comp = new Computer();

            Console.WriteLine("Give me a message");

            message = Console.ReadLine();

            comp.TakeNote(message);

            //Using the MobilePhone class
            MobilePhone celly = new MobilePhone();

            if (celly.PowerOn())
            {
                Console.WriteLine("Give me your message!");
                 message = Console.ReadLine();

                celly.TakeNote(message);

            }
            else
            {
                Console.WriteLine("I cannot help you if you don't turn me on!");
            }
        }
    }
}
