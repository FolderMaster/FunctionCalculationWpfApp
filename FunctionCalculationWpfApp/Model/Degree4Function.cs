using System;

namespace FunctionCalculationWpfApp.Model
{
    public class Degree4Function : Function
    {
        private static double[] _cValues = new double[] { 1000, 2000, 3000, 4000, 5000 };

        public override double[] CValues => _cValues;

        public Degree4Function()
        {
            C = CValues[0];
        }

        public override double Calculate(double x, double y) =>
            A * Math.Pow(x, 4) + B * Math.Pow(x, 3) + C;

        public override string ToString() => "4 degree";
    }
}