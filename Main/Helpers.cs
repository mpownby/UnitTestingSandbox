using MathLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    public class Helpers : IHelpers
    {
        private readonly IUtilMath mathUtil;

        public Helpers(IUtilMath injectedMathUtil)
        {
            this.mathUtil = injectedMathUtil;
        }

        public int MagicNumberHelper(int a, int b)
        {
            int result;

            switch (a % 3)
            {
                case 0:
                    result = this.mathUtil.Subtract(a, b);
                    break;
                case 1:
                    result = this.mathUtil.Multiply(a, b);
                    break;
                case 2:
                    result = this.mathUtil.Divide(a, b);
                    break;
                default:
                    throw new NotSupportedException();
            }

            return result;
        }
    }
}
