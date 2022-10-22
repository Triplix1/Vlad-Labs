using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    internal class DocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine("Документ відкритий");
        }
        public void EditDocument() 
        {
            Console.WriteLine("Правка документа доступна у версії Про");
        }
        public void SaveDocument() 
        {
            Console.WriteLine("Збереження документа доступне у версії Про");
        }
    }
}
