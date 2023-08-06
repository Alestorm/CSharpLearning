using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainConsoleProject.Basics
{
    public class BasicCSharp
    {
        public void MainMethod()
        {
            /*C# is a statically - typed language, which means that everything has a type in compile-time
             * - Naming a variable means that you are defining that variable.
             * - Once a variable is defined, setting or updatating a value is called variable assignment.
             * - A variable can be definied explicitly by defining its type or by using the "var" keyword
             * - When you use "var", c# infers the type of the variable based on the assigned value
             * */


            ExplicitlyTyped();


        }
        /// <summary>
        /// Example of explicitly defined variables in c# with primitive types
        /// </summary>
        public void ExplicitlyTyped()
        {
            Console.WriteLine("Example of explicitly defined variables in c# with primitive types\n");
            //booleans
            bool trueBooleanValue = true;
            bool falseBooleanValue = false;
            Console.WriteLine("Boolean value: " + trueBooleanValue);

            //byte
            byte byteMinValue = 0;
            byte byteMaxValue = 255;
            Console.WriteLine("byte value: " + byteMaxValue);

            //sbyte
            sbyte sbyteMinValue = -128;
            sbyte sbyteZero = 0;
            sbyte sbyteMaxValue = 127;
            Console.WriteLine("sbyte value: " + sbyteMaxValue);

            //short
            short shortMinValue = -32768;
            short shortMaxValue = 32767;
            Console.WriteLine("short value: " + shortMaxValue);

            //ushort
            ushort ushortMinValue = 0;
            ushort ushortMaxValue = 65535;
            Console.WriteLine("ushort value: " + ushortMaxValue);

            //int - Stores whole numbers from -2,147,483,648 to 2,147,483,647
            int integerValue = 10;
            int integerValue2 = 42;
            int integerNevative = -3;
            int intMinValue = -2147483648;
            int intMaxValue = 2147483647;
            Console.WriteLine("int value: " + intMaxValue);

            //uint
            uint uintMinValue = 0;
            uint uintMaxValue = 4294967295;
            Console.WriteLine("uint value: " + uintMaxValue);

            //long - Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            long longValue = 23;
            long longValue2 = -5665;
            long longMinValue = -9223372036854775808;
            long longMaxValue = 9223372036854775807;
            Console.WriteLine("long value: " + longMaxValue);

            //ulong 
            ulong ulongMinValue = 0;
            ulong ulongMaxValue = 18446744073709551615;
            ulong ulongValue = 655;
            Console.WriteLine("ulong value: " + ulongMaxValue);

            //float - Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
            float floatNumber = 45.5f;
            float floatNumber2 = 1522.1234f;
            float floatNevative = -223.12f;
            Console.WriteLine("float value: " + floatNumber2);

            //double - Stores fractional numbers. Sufficient for storing 15 decimal digits
            double doubleNumber = 15887.545;
            double doubleNevative = -565;
            Console.WriteLine("double value: " + doubleNumber);

            //decimal - is more precise than float and decimal
            decimal decimalValue = 1234.56789m;
            decimal decimalPrice = 39.99m;
            Console.WriteLine("decimal value: "+decimalPrice);

            //char - represents one single character
            char letterA = 'A';
            char symbol = '#';
            char numberAsChar = '5';
            char letterz = 'z';
            Console.WriteLine("char value: " + symbol);

            //string - represents a group of chars, can be a whole phrase for example "This is a string" or a single character "S"
            string gretting = "Hey, Pedro";
            string initialLetter = "P";
            string clothesPrice = "The price is $39.99";
            Console.WriteLine("Example text: "+clothesPrice);

        }
    }
}
