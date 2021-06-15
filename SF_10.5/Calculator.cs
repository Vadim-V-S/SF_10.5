using System;
using System.Collections.Generic;
using System.Text;

namespace SF_10._5
{
    public interface ICalculator
    {
        void Calculate();
    }

    class Calculator : ICalculator
    {
        public double Num1;
        public double Num2;
        Logger logger = new Logger();

        ILogger Logger { get; }

        public Calculator(ILogger logger) { this.Logger = logger; }

        public Calculator(double num1, double num2)
        {
            Num1 = num1;
            Num2 = num2;
        }

        public void Calculate()
        {
            logger.Event($"Сумма = {Num1 + Num2}\n");
        }
    }

}