using System;

namespace Do_While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNum = 1;

            Console.WriteLine("This screen displays numbers using a DO...WHILE loop");
            Console.WriteLine();
            do
            {
                Console.WriteLine(iNum);
                iNum++;
            } while (iNum <= 10);
            Console.ReadLine();
            Console.Clear();
        }
    }
}
