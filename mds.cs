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
                return "";
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

            int previousSeparatorIndex = 0;                             // index of the previous separator comma. 
            int seperatorcount = 0;

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == ',')
                {
                    // separator has been read from data . 


                    if (seperatorcount == index)
                    {
                        // when we reach the index that we seek the element ,
                        // get the element at the current index using the current seperator index and the previous seperator index.

                        for (int j = previousSeparatorIndex; j < i; j++)
                        {
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