using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("I study godd");
        }
        public override void Read()
        {
            Console.WriteLine("I read good");
        }
        public override void Write()
        {
            Console.WriteLine("I write good");
        }
        public override void Relax()
        {
            base.Relax(); Console.WriteLine("I relax enought");
        }
    }
}
