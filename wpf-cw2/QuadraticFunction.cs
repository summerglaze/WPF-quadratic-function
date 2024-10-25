using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace wpf_cw2
{
    class QuadraticFunction
    {
        public double WspA { get; } //set jest private
        public double WspB { get; }
        public double WspC { get; }

        public QuadraticFunction(double wspA, double wspB, double wspC)
        {
            WspA = wspA; 
            WspB = wspB; 
            WspC = wspC;
        }

        public string calculate()
        {
            
            if (WspA == 0)
            {
                return "a=0"+ System.Environment.NewLine + "To nie jest równanie kwadratowe.";
            } else
            {
                double result;
                double delta = WspB * WspB - 4 * WspA * WspC;

                if (delta < 0)
                {
                    return "Delta < 0." + System.Environment.NewLine + "Brak rozwiązań.";

                } else if (delta == 0)
                {
                    result = -WspB / (2*WspA);
                    return "Rozwiązanie x="+result;
                } else
                {
                    double x1 = (-WspB + Math.Sqrt(delta)) / (2 * WspA);
                    double x2 = (-WspB - Math.Sqrt(delta)) / (2 * WspA);
                    return "Rozwiązaniem są dwa miejsca zerowe x1=" + x1 + ", x2=" + x2;
                }
            }
        }

        public string showFunction()
        {
            string inputFunction = "";
            if (WspA < 0) { inputFunction += "(" + WspA + ")*x\\xB2"; } else if (WspA>0) { inputFunction = WspA.ToString()+ "*x\\xB2"; }
            if (WspA !=0 && WspB!=0) { inputFunction += " + "; }
            if (WspB < 0) { inputFunction += "(" + WspB + ")*x"; } else if (WspB>0) { inputFunction += WspB+ "*x"; }
            if ((WspB != 0 && WspC != 0) || (WspB==0 && WspA !=0 && WspC != 0)) { inputFunction += " + "; }
            if (WspC < 0) { inputFunction += "(" + WspC + ")"; }else if (WspC>0){inputFunction += WspC;}
            
            string inputFunction2= Regex.Unescape(inputFunction);
            
            return inputFunction2;
        }
    }
}
