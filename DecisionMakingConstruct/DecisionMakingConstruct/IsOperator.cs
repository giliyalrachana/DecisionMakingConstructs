using System;

namespace GettingStartedWithCSharp
{
    class IsAOperator
    {
        static void Main()
        {
            // Is operator returns true if the given object is of the same type
            C c = new A();
            Console.WriteLine (c is D);
            D d = new B();
            Console.WriteLine(d is C);
            Console.ReadLine();

        }
    }
    class C
    {

    }
    class D : C
    {

    }
}
