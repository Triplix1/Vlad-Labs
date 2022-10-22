using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class Pupil
    {
        public virtual void Study() { }
        public virtual void Read() { }
        public virtual void Write() { }
        public virtual void Relax() { }
        public virtual void Print()
        {
            Study();
            Read();
            Write();
            Relax();
        }
    }
}
