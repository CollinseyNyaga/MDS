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
            // test2();
            // test3();
            // test4();
            // test5();
            test6();
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
            System.Console.WriteLine(myArr.GetElement(1));


        }


        static void test3()
        {
            // checking if an element is contained in the Universal container created as an object . 
            Mds.Ucont mycont = new Mds.Ucont();
            mycont.AddElement("hello");
            mycont.AddElement("5");
            mycont.AddElement("world");

            bool A = mycont.Contains("5");                          // check if 5 is contained in the ucont container. 
            bool B = mycont.Contains("seven");                      // check if seven is contained in the ucont container. 

            System.Console.WriteLine("mycont = " + mycont.GetRawData());
            System.Console.WriteLine("------------------");
            System.Console.WriteLine($"mycont contains 5: {A}");
            System.Console.WriteLine($"mycont contains seven: {B}");

        }

        static void test4()
        {
            // getting an element that is out of range . 
            Mds.Ucont mycont = new Mds.Ucont();

            mycont.AddElement("hello");
            mycont.AddElement("world");
            mycont.AddElement("kenya");


            System.Console.WriteLine(mycont.GetElement(index: 3));
        }

        static void test5()
        {
            // printing out the size of a ucont container : 
            Mds.Ucont uc = new Mds.Ucont();
            uc.AddElement("hello");
            uc.AddElement("world");

            System.Console.WriteLine(uc.Size);
        }

        static void test6()
        {
            // removing an element at the specified index. 

            Mds.Ucont ucc = new Mds.Ucont();
            ucc.AddElement("hello");
            ucc.AddElement("hey there");

            System.Console.WriteLine(ucc.Size);
            ucc.RemoveElement(1);
        }

    }
}