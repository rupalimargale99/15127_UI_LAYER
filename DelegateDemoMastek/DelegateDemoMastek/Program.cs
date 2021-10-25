using System;

namespace DelegateDemoMastek
{
    //Step 1
    delegate int CalculatorDelegate(int first, int second);
    class Program
    {
        //step 2
        static int MulNumbers(int number1, int number2)
        {
            return number1 * number2;
        }
        static int AddNumbers(int number1, int number2)
        {
            return number1 + number2;
        }
        static int MinusNumbers(int number1, int number2)
        {
            return number1-number2;
        }
        static void Main(string[] args)
        {
            //step3- delegate instance -points to a method
            // CalculatorDelegate demo1 = new CalculatorDelegate(AddNumbers);
            CalculatorDelegate demo1 = MulNumbers;
            CalculatorDelegate demo2 = AddNumbers;
            CalculatorDelegate demo3 = MinusNumbers;

            //step4 invoke delegate
            int result = demo1(5, 6);
            int result1 = demo2(5, 6);
            int result2 = demo3(5, 5);
            Console.WriteLine("Multiplication:" + result);
            Console.WriteLine("Addition:" + result1);
            Console.WriteLine("Substraction:" + result2);
            Console.WriteLine("-----------");

            //Lambda Expression 
            //merge Step2+3
            //(input param)=>expression

            CalculatorDelegate demo01 = (a, b) => a + b;
            result =demo01(2,4);
            Console.WriteLine("Addition= " + result);

            CalculatorDelegate demo02 = (a, b) => a * b;
            result1 = demo02(2, 4);
            Console.WriteLine("Multiplication= " + result1);

            CalculatorDelegate demo03 = (a, b) => a-b;
            result2 = demo03(5,2);
            Console.WriteLine("Substraction= " + result2);

            demo01 = (x, y) => x * y;
            result = demo01(12, 5);

            //Action/Action<T>
            

        //Func<>

        // Predicate
    }
    }
}
