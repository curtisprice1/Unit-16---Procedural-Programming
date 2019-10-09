using System;

namespace Switch_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            string sfullName;
            string sgreeting;

            Console.Write("Please enter your full name: ");
            sfullName = Console.ReadLine();

            switch (sfullName)
            {
                case "Bill Gates":
                    sgreeting = "Great job on C#";
                    break;

                case "Cathy Folkard":
                    sgreeting = "That Cathy is really cool";
                    break;

                case "Alan Turing":
                    sgreeting = "The Turing machine was pretty amazing";
                    break;

                default:
                    sgreeting = "We're waiting for your contibution to computer science, " + sfullName;
                    break;
            }

            Console.WriteLine(sgreeting);
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
