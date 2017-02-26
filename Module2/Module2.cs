using System;

namespace cSharpModule2
{
    public class Module2
    {
        public static void Main(string[] args)
        {
            string gridAttribute = "X";
            for (int gridRow = 0; gridRow < 8; gridRow++)
            {
                for (int gridColumn = 0; gridColumn < 8; gridColumn++)
                {
                    Console.Write(gridAttribute);
                    GetGridAttribute(ref gridAttribute);
                }
                Console.WriteLine();
                GetGridAttribute(ref gridAttribute);
            }
            Console.ReadLine();
        }
        static void GetGridAttribute(ref string gridXO)
        {
            if (gridXO == "X")
            {
                gridXO = "O";
            }
            else
            {
                gridXO = "X";
            }
        }
    }
}