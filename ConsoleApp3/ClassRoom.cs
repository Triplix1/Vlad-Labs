using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class ClassRoom
    {
        List<Pupil> pupils;
        public ClassRoom(Pupil pupil, Pupil pupil2)
        {
            pupils.Add(pupil);
            pupils.Add(pupil2);
        }
        public ClassRoom(Pupil pupil, Pupil pupil2, Pupil pupil3) : this(pupil, pupil2)
        {
            pupils.Add(pupil3);
        }
        public ClassRoom(Pupil pupil, Pupil pupil2, Pupil pupil3, Pupil pupil4) : this(pupil, pupil2, pupil3)
        {
            pupils.Add(pupil4);
        }
        public void PrintDeatils()
        {
            foreach (Pupil pupil in pupils)
            {
                pupil.Print();
            }
        }
    }
}
