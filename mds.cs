/*
    The main library file 

*/


namespace Mds
{
    public class Ucont
    {
        // Ucont attributes 
        private string Data = "";
        public int Size = 0;                           // number of elements - 1.
        UcontMode Mode = UcontMode.list;
        public static char dataSeparator = ']';


        //

        // Ucont constants / enumerations
        enum UcontMode
        {
            list,                                   // the default mode of the datastructure.
            singletype,
            graph
        }


        //

        // Ucont methods 
        public void AddElement(string element)
        {
            // the separator is variable and is used to make work easier for the lexer to determine the end of a piece of data. 

            Data = $"{Data}{element}{dataSeparator}";
        }

        public string GetElement(uint index)
        {
            // we only get element when its within the size of the array : 
            if (index >= Data.Length)
            {
                return "";
            }

            return Mds.Lexer.GetElement(data: Data, index: index);
        }

        public void ReplaceElement(int index)
        {

        }

        public bool Contains(string element)
        {
            uint elementCount = (uint)Size;

            for (uint i = 0; i <= elementCount; i++)
            {
                System.Console.WriteLine(i);

                // check if the element is contained in the container in a reverse order.
                if(GetElement(i) == element)
                {
                    return true;
                }
            }

            return false;
        }



        public string GetRawData()
        {
            // gets the data stored inform of string in the data container itself. 
            return Data;
        }


    }



    // another class : 
    static class Lexer
    {
        public static string GetElement(string data, uint index)
        {
            string element = "";

            int previousSeparatorIndex = 0;                             // index of the previous separator comma. 
            int seperatorcount = 0;

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == Ucont.dataSeparator)
                {
                    // separator has been read from data . 


                    if (seperatorcount == index)
                    {
                        // when we reach the index that we seek the element ,
                        // get the element at the current index using the current seperator index and the previous seperator index.

                        for (int j = previousSeparatorIndex; j < i; j++)
                        {
                            if (data[j] == Ucont.dataSeparator) continue;

                            element = element + data[j];                  // append the current character to the element string
                        }

                        return element;
                    }

                    previousSeparatorIndex = i;
                    seperatorcount = seperatorcount + 1;
                }
            }


            return element;
        }
    }
}