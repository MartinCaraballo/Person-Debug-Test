using System;

namespace UnitTestAndDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person("John Doe", "1.234.567-8");
            Person jane = new Person("Jane Doe", "8.765.432-1");
            Person martin = new Person("Martín", "53037997");
            Person gustavo = new Person("Gustavo", "3.705.159-9");
            john.IntroduceYourself();
            jane.IntroduceYourself();
            martin.IntroduceYourself();
            gustavo.IntroduceYourself();
        }
    }
}
