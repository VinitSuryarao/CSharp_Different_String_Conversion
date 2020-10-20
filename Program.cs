using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_String_Conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            // As String
            string A = "Test";
            string B = A as string; // Convert to String

            string C = null;
            string D = A as string; // Not Give Error For Null Data


            // Convert.ToString()
            string V = "Test";
            string W = Convert.ToString(V); // Convert to String

            string X = null;
            string Y = Convert.ToString(X); // Not Give Error For Null Data

            // (string)Object
            Object E = "Test";
            string F = (string)E; // Convert to String

            Object G = null;
            string H = (string)G; // Give Error For Null Data

            // .ToString()
            Object M = "Test";
            string N = M.ToString(); // Convert to String

            Object O = null;
            string P = O.ToString(); // Give Error For Null Data

        }
    }
}
