using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassRoom room = new ClassRoom(new ExcelentPupil(), new GoodPupil(), new BadPupil());
            room.PrintDeatils();
        }
    }
}
