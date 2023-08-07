using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainConsoleProject.Basics.Booleans
{
    public class BooleanBasicExamples
    {
        public void MainBooleanExamples()
        {
            BooleanDeclaration();
            ORTruthTable();
            ANDTruthTable();
            NOTTruthTable();

            //exercises with booleans
            Console.WriteLine("Excercises with booleans");
            BooleanExercises booleanExercises = new BooleanExercises();
            booleanExercises.CompareValues();
        }

        /// <summary>
        /// Method that shows how to declare booleans and examples of basic logic operations
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void BooleanDeclaration()
        {
            bool a = true;
            bool b = false;
            var resultAnd = a && b; //implictly typed
            var resultOr = a || b; //implictly typed
            var resultNot = !a; //implictly typed

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("a and b = " + resultAnd);
            Console.WriteLine("a or b = " + resultOr);
            Console.WriteLine("(not)a = " + resultNot);
            Console.WriteLine();
        }

        /// <summary>
        /// Method that shows the Truth table for the operator OR
        /// </summary>
        public void ORTruthTable()
        {
            Console.WriteLine("---OR Truth table---");
            Console.WriteLine("T || T = " + (true || true));
            Console.WriteLine("T || F = " + (true || false));
            Console.WriteLine("F || T = " + (true || false));
            Console.WriteLine("F || F = " + (false || false));
            Console.WriteLine();
        }

        /// <summary>
        /// Method that shows the Truth table for the operator AND
        /// </summary>
        public void ANDTruthTable()
        {
            Console.WriteLine("---AND Truth table---");
            Console.WriteLine("T && T = " + (true && true));
            Console.WriteLine("T && F = " + (true && false));
            Console.WriteLine("F && T = " + (true && false));
            Console.WriteLine("F && F = " + (false && false));
            Console.WriteLine();
        }

        /// <summary>
        /// Method that shows the Truth table for the operator NOT
        /// </summary>
        public void NOTTruthTable()
        {
            Console.WriteLine("---NOT Truth table---");
            Console.WriteLine("!T = " + !true);
            Console.WriteLine("!F = " + !false);
            Console.WriteLine();
        }
    }
}
