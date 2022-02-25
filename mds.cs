/*
    The main library file 

*/

using Mds;

namespace Mds
{
    public class Ucont
    {
        // Ucont attributes 
        private string Data = "";
        private int size = 0;                           // number of elements - 1.
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


        // properties : 
        public int Size
        {
            // readonly , cannot be set from external class .
            get { return size; }
        }







        // 

        // Ucont methods 
        public void AddElement(string element)
        {
            // the separator is variable and is used to make work easier for the lexer to determine the end of a piece of data. 

            Data = $"{Data}{element}{dataSeparator}";
            size = size + 1;
        }

        public string GetElement(uint index)
        {
            // we only get element when its within the size of the array : 
            if (index >= size)
            {
                // return "index is outside the bounds of the ucont container";
                throw new Mds.OutOfRangeError("index provided is not within the ucont container");
            }

            return Mds.Lexer.GetElement(data: Data, index: index);
        }

        public void ReplaceElement(int index)
        {

        }

        public bool Contains(string element)
        {
            for (uint i = 0; i <= size; i++)
            {
                // check if the element is contained in the container
                if (GetElement(index: i) == element)
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

        public void RemoveElement(uint index)
        {
            // remove an element at the specified index .
            if (index > size)
            {
                throw new Mds.OutOfRangeError("the element at the specified index cannot be removed because it doesnt exist");
            }
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