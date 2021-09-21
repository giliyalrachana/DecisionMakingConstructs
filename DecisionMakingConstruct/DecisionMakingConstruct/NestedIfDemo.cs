using System;

namespace DecisionMakingConstruct
{
    // This program demo. how to nest if condition
    class NestedIfDemo
    {
        static void Main()
        {
            Console.Write("Enter Highest Qualification(UG/PG):");
            string qualification = Console.ReadLine();
            qualification = qualification.ToLowerInvariant();

            Console.Write("Enter Experience in (Months):");
            int months = int.Parse(Console.ReadLine());
            if (qualification == "pg")
            {
                if (months >= 12)
                {
                    Console.WriteLine("You are eligible for interview");
                }
                else
                {
                    Console.WriteLine("Experience must be greater than to 12");
                }
            }
            else
            {
                Console.WriteLine("Qualification must be pg");
            }
            Console.ReadLine();
        }
    }
}
