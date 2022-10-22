using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("I study exelent");
        }
        public override void Read()
        {
            Console.WriteLine("I read exelent");
        }
        public override void Write()
        {
            Console.WriteLine("I write exelent");
        }
        public override void Relax()
        {
            base.Relax(); Console.WriteLine("I relax rereyl");
        }
    }
}
