using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainConsoleProject.Basics.Booleans
{
    public class BooleanExercises
    {
        public void CompareValues()
        {
            int numero1 = 15;
            int numero2 = 25;

            if(numero1 == numero2)
            {
                Console.WriteLine(numero1+" y "+ numero2 +" son iguales");
            }
            else
            {
                Console.WriteLine(numero1 + " y " + numero2 + " no son iguales");
            }
        }
    }
}
