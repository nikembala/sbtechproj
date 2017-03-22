using System;

namespace Class.Method.Variable.Type
{
    public class DeclareVariables
    {
        // declares a field
        int a;

        // declare and initilize field
        double b = 123.33d;

        // declares a property
        public int A
        {
            get; set;
        }

        // declare a constructor without parameters
        public DeclareVariables()
        {
        }

        // declare a constructor with parameter
        public DeclareVariables(int p)
        {
            this.A = p;
        }

        // declare a method without return type
        public void PrintValue()
        {
            Console.WriteLine(A);
        }

        // declare a method with return type
        public string GetMyValue()
        {
            return A.ToString();
        }
    }
}
