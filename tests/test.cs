/*
    the main testing program source . 
*/

using System;
using Mds;                      // the mutating datastructure library namespace.

namespace test
{
    class testClass
    {
        static void Main()
        {
            // test0();
            test1();
        }


        // 

        static void test0()
        {
            System.Console.WriteLine("hello data structure");
        }
        static void test1()
        {
            // adding an element to the universal container : 
            string fname = "mutant";
            string lname = "mutate";

            Mds.Ucont myArray = new Mds.Ucont(); 
            myArray.AddElement(fname);      
            myArray.AddElement(lname);     
        }

    }
}