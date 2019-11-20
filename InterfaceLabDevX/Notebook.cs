using System;

namespace InterfaceLabDevX
{
    class Notebook : INotation
    {
        public void TakeNote(string message)
        {
            Console.WriteLine($"Your message: {message} has been written.");
        }

    }
}