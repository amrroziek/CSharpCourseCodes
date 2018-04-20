using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes_CharStringBoolTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int charMin = Char.MinValue;
            int charMax = Char.MaxValue;

            char MyVar = 'G';
            int myVarValue = 'G';

            char myVarValue2 = Convert.ToChar(75);
            Console.WriteLine("\n Min Char = {0}\n Max Char = {1} \n myChar = {2} \n My Variable number = {3}\n My Variable2 number = {4}", charMin,charMax,MyVar,myVarValue,myVarValue2);


            string myString = "This is My Variable";
            Console.WriteLine("\n My String is {0} ", myString);

            bool myBool = true;
            Console.WriteLine("my Boolean Value is {0}", myBool);

            Console.ReadKey();
        }
    }
}
