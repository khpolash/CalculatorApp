using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Calculator
    {
        public double firstNumber;
        public double secondNumber;
        
        public double Add(double fNumber, double sNumber)
        {
            return (fNumber + sNumber);
        }
        public double Sub(double fNumber, double sNumber)
        {
            return (fNumber - sNumber);
        }
        public double Mul(double fNumber, double sNumber)
        {
            return (fNumber * sNumber);
        }
        public double Div(double fNumber, double sNumber)
        {
            return (fNumber / sNumber);
        }
       
    }
}
