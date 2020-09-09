using MathLib;
using System;

namespace Main
{
    class Program
    {
        private const string Message = "I am expecting two arguments.";

        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                throw new ArgumentException(Message);
            }

            int a = Convert.ToInt32(args[0]);
            int b = Convert.ToInt32(args[1]);

            var instance = new Program();

            Console.WriteLine("The magic number is {0}", instance.GetMagicNumber(a, b));
        }

        public int GetMagicNumber(int a, int b)
        {
            while (b > 0)
            {
                a = UtilMath.Multiply(a, b);

                b /= 2;
            }

            b = -a;

            return MagicNumberHelper(a, b);
        }

        private int MagicNumberHelper(int a, int b)
        {
            int result;

            switch (a % 3)
            {
                case 0:
                    result = UtilMath.Subtract(a, b);
                    break;
                case 1:
                    result = UtilMath.Multiply(a, b);
                    break;
                case 2:
                    result = UtilMath.Divide(a, b);
                    break;
                default:
                    throw new NotSupportedException();
            }

            return result;
        }
    }
}
