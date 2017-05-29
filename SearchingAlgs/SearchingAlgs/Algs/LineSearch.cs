namespace SearchingAlgs.Algs
{
    class LineSearch
    {
        
        //not a solution to store a coords;
        //maybe search func must return a tuple?
        //public static int positionX, positionY; not need after updating and using tuple


        public static int Search(int[] a, int XKey)
        {
            for(int i = 0; i < a.Length; i++)
                if(a[i] == XKey)
                    return i; // return position
            
            return -1; // if not exist
        }
        
        public static bool IsExist(int[a], int XKey)
        {
             for(int i = 0; i < a.Length; i++)
                if(a[i] == XKey)
                    return true; // true if exist
            
            return false; // if not exist  
        }

        public static Tuple<int,int> multiArraySearch(int[,] values, int xKey)
        {
            int counter = 0; // absolute position of the xKey element
            foreach (int i in values)
            {     
                if (i == xKey) // looking for the first input in array values
                {
                    int elementString = (int)(counter / (values.GetLongLength(0))); // row found
                    int elementPosition = (int)(counter % (values.GetLongLength(0))); // col found
                    if (counter == values.GetLongLength(0)) // if position of last element in current array string == last element in string, prev operation will return 0
                        elementPosition = (int)(values.GetLongLength(0) - 1); // will be last element in row 
                                                                               // (-1) just for current array iteration started with 0
                    return Tuple.Create(elementString, elementPosition); //tuple returned
                }
                counter++;
            }
            return Tuple.Create(-1, -1); // not found
        }
    }
}
