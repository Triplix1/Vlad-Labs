using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("I study bad");
        }
        public override void Read()
        {
            Console.WriteLine("I read bad");
        }
        public override void Write()
        {
            Console.WriteLine("I write bad");
        }
        public override void Relax()
        {
            base.Relax(); Console.WriteLine("I relax very much");
        }
    }
}
