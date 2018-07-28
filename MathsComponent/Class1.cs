using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsComponentNameSpace
{
    public class MathsComponent
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public bool CheckPasswdLen(string pass)
        {
            if(pass.Length >= 8)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public int CheckGreater(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }

        }
    }
}
