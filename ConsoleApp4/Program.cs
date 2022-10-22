using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DocumentWorker worker;
            Console.WriteLine("Input key");
            string key = Console.ReadLine();
            if (key == "exp")
            {
                worker = new ExpertDocumentWorker();
            }
            else if (key == "pro")
            {
                worker = new ProDocumentWorker();
            }
            else
            {
                worker = new DocumentWorker();
            }
            worker.OpenDocument();
            worker.EditDocument();
            worker.SaveDocument();
        }
    }
}
