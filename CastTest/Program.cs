using System;

namespace CastTest
{
    class Program
    {
        static void Main(string[] args)
        {
            short aShortValue = 10;
            int anIntValue = short.MaxValue + 1;

            aShortValue = anIntValue; //CS0266 - Der Typ "int" kann nicht implizit in "short" konvertiert werden.

            aShortValue = (short)anIntValue;
            Console.WriteLine($"anIntValue hat den Wert {anIntValue}");
            Console.WriteLine($"aShortValue hat den Wert {aShortValue} nach dem explicit Cast");
        }
    }
}
