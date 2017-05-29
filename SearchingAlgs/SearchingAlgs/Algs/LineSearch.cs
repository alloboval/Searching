namespace SearchingAlgs.Algs
{
    class LineSearch
    {
        
        //not a solution to store a coords;
        //maybe search func must return a tuple?
        public static int positionX, positionY;


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

        public static void Search(int[][] a, int XKey)
        {
            //will be
        }
    }
}
