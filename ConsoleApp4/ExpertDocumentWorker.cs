using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    internal class ExpertDocumentWorker :ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ збережений в новому форматі");
        }
    }
}
