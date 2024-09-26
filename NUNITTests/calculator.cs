using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumTraining
{
    internal class calculator
    {
        //addition
        public int Add(int a,int b)
        {
            int c=a+b;
            return c;
        }

        //subtraction
        public int subtract(int a,int b)
        {
            int c = a - b;
            return c;
        }

        //multiplication
        public int mul(int a,int b)
        {
            int c = a*b;    
            return c;
        }

        //division
        public int division(int a,int b)
        {
            int c = a/b;
            return c;
        }
    }
}
