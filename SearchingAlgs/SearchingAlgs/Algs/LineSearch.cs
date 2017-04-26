namespace SearchingAlgs.Algs
{
    class LineSearch
    {
        public static int positionX, positionY;


        public static void Search(int[] a, int XKey)
        {
            for(int i = 0; i < a.Length; i++)
            {
                if(a[i] == XKey)
                {
                    positionX = i;
                }
            }
        }

        public static void Search(int[][] a, int XKey)
        {
            //will be
        }
    }
}
