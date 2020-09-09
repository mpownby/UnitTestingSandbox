using MathLib;
using System;

namespace Main
{
    public class Program
    {
        private readonly IUtilMath mathUtil;
        private readonly IHelpers helpers;

        private const string Message = "I am expecting two arguments.";

        // This method is difficult to unit test, so we try to make it as small/simple as possible instead
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                throw new ArgumentException(Message);
            }

            int a = Convert.ToInt32(args[0]);
            int b = Convert.ToInt32(args[1]);

            // for real projects, we'd use a dependency injection framework
            var mathUtil = new UtilMath();
            var instance = new Program(new Helpers(mathUtil), mathUtil);

            Console.WriteLine("The magic number is {0}", instance.GetMagicNumber(a, b));
        }

        public Program(IHelpers injectedHelpers, IUtilMath injectedMathUtil)
        {
            this.mathUtil = injectedMathUtil;
            this.helpers = injectedHelpers;
        }

        public int GetMagicNumber(int a, int b)
        {
            while (b > 0)
            {
                a = this.mathUtil.Multiply(a, b);

                b /= 2;
            }

            b = -a;

            return helpers.MagicNumberHelper(a, b);
        }
    }
}
