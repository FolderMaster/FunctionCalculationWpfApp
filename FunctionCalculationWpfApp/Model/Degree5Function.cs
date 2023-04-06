using System;

namespace FunctionCalculationWpfApp.Model
{
    public class Degree5Function : Function
    {
        private static double[] _cValues = new double[] { 10000, 20000, 30000, 40000, 50000 };

        public override double[] CValues => _cValues;

        public Degree5Function()
        {
            C = CValues[0];
        }

        public override double Calculate(double x, double y) =>
            A * Math.Pow(x, 5) + B * Math.Pow(x, 4) + C;

        public override string ToString() => "5 degree";
    }
}