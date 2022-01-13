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
            // test1();
            test2();
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

            System.Console.WriteLine(myArray.GetRawData());
        }

        static void test2()
        {
            // getting an element from the specified index : 

            // object of the universal container: 
            Mds.Ucont myArr = new Mds.Ucont();
            string name1 = "hello";
            string name2 = "world";
            string name3 = "this is the universal data container";

            // add the names to the universal container object we created. 
            myArr.AddElement(name1);
            myArr.AddElement(name2);
            myArr.AddElement(name3);

            // get the elements from the container .[keep in mind that we only have a container of size 2]
            string firstElement = myArr.GetElement(0);
            System.Console.WriteLine(firstElement);
            System.Console.WriteLine(myArr.GetElement(2));


        }

    }
}