using System;

namespace FunctionCalculationWpfApp.Model
{
    public class СubicFunction : Function
    {
        private static double[] _cValues = new double[] { 100, 200, 300, 400, 500 };

        public override double[] CValues => _cValues;

        public СubicFunction()
        {
            C = CValues[0];
        }

        public override double Calculate(double x, double y) =>
            A * Math.Pow(x, 3) + B * Math.Pow(x, 2) + C;

        public override string ToString() => "Сubic";
    }
}