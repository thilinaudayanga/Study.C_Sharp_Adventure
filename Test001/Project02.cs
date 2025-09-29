using System;


namespace Basic001.Test001
{
    class Project02
    {
        static void Main(String[] args)
        {
            Console.Write("Enter Number 1 : ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter Number 2 : ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Addition is : " + (num1+num2));
            Console.WriteLine("Substraction is : " + (num1-num2));
            Console.WriteLine("Multiplication is : " + (num1 * num2));

            if(num2 != 0)
            {
                Console.WriteLine("Divition is : " + (num1 / num2));
            }
            else
            {
                Console.WriteLine("Divition Can not do Write now , Your second number is 0");
            }






        }
    }
}
