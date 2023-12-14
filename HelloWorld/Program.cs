using System; // include system lib (classes, structs, etc...)

namespace HelloWorld
{
    class Program
    {
        static int addNumber(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            /*
             Implement StringToByte
            */

            string str = "Pratham Asrani";
            byte[] arr = new byte[str.Length];

            for (int i = 0; i < str.Length; i++) arr[i] = Convert.ToByte(str[i]);
            for (int i = 0; i < arr.Length; i++) Console.WriteLine("Byte of char\'" + str[i] + "\': " + arr[i]);


            int num = 1;
            Console.WriteLine("num: " + num);

            float f = 1.1F;
            Console.WriteLine("float: " + f);

            double d = 1.477474775;
            Console.WriteLine("double: " + d);

            bool is_greater = num > f ? true : false;
            string s = is_greater == true ? "num is greater" : "float is greater";
            Console.WriteLine(s);

            Console.WriteLine("Output of some function: "  + (addNumber(2, 3) + 5));
            Console.WriteLine("Output of some function: " + Convert.ToInt32(addNumber(3, 3) + 5));

            Console.ReadLine();
        }
    }
}

