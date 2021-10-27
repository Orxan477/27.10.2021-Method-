using System;

namespace Method_classTask
{
    class Program
    {
        #region menfileri musbet etmek
        static void Main(string[] args)
        {
            int[] arr = { -1, 36, -50 };
            massiv(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        static int[] massiv(int[] musbet)
        {

            for (int i = 0; i < musbet.Length; i++)
            {
                if (musbet[i] < 0)
                {
                    musbet[i] = musbet[i] * (-1);
                }
            }
            return musbet;
        }
        #endregion  
    }
}
