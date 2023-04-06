using System;

namespace FunctionCalculationWpfApp.Model
{
    public class QuadraticFunction : Function
    {
        private static double[] _cValues = new double[] { 10, 20, 30, 40, 50 };

        public override double[] CValues => _cValues;

        public QuadraticFunction()
        {
            C = CValues[0];
        }

        public override double Calculate(double x, double y) =>
            A * Math.Pow(x, 2) + B * y + C;

        public override string ToString() => "Quadratic";
    }
}