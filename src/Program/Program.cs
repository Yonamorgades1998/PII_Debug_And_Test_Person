using System;

namespace UnitTestAndDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person("John Doe", "1.234.567-8" , "18/07/1998");
            john.IntroduceYourself();
        }
    }
}
