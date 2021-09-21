using System;

namespace DecisionMakingConstruct
{
    // This program demo. how to use ternary operator
    class TernaryDemo
    {
        static void Main()
        {
            Console.Write("Enter Annual Income:");
            double annualIncome = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(annualIncome >= 280000 ? "You are liable to pay I.T." : "You are not liable to pay I.T.");
            Console.ReadLine();

        }
    }
}
