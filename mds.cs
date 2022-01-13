/*
    The main library file 

*/


namespace Mds
{
    public class Ucont
    {
        // Ucont attributes 
        private string Data = "";
        private int Size = 0;                           // number of elements - 1.
        UcontMode Mode = UcontMode.list;


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
            Data = $"{Data}{element},";
        }

        public string GetElement(uint index)
        {
            // we only get element when its within the size of the array : 
            if (index >= Data.Length)
            {
                break;
            }

            return Mds.Lexer.GetElement(data: Data, index: index);
        }

        public void ReplaceElement(int index)
        {

        }

        public bool Contains()
        {
            return false;
        }

        public string GetRawData()
        {
            // gets the data stored inform of string in the 
            return Data;
        }
    }



    // another class : 
    static class Lexer
    {
        public static string GetElement(string data, uint index)
        {
            string element = "";

            uint previousSeparatorIndex = 0;
            uint seperatorcount;

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == ',')
                {
                    // separator has been read from data . 


                    // get the element at the current index using the current seperator index and the previous seperator index.
                    if (seperatorcount == index)
                    {
                        // when we reach the index that we seek the element ,
                        
                    }


                    if (i + 1 == index)
                    {
                        for (int j = previousSeparatorIndex + 1; j < i; j++)
                        {
                            element = element + j;                  // append the current character to the element string
                        }
                    }



                    previousSeparatorIndex = previousSeparatorIndex + 1;
                    seperatorcount = seperatorcount + 1;
                }
            }



            return element;
        }
    }
}