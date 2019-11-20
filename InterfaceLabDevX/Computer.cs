using System.IO;

namespace InterfaceLabDevX
{
    class Computer : INotation
    {
        public void TakeNote(string message)
        {

            string filePath = @"C:\Users\hphifer\source\repos\InterfaceLabDevX\InterfaceLabDevX\NotebookData.txt";
            StreamWriter sw = new StreamWriter(filePath);

            sw.WriteLine(message);
            sw.Close();
        }
    }
}