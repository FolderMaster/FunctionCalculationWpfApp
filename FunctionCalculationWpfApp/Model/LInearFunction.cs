namespace FunctionCalculationWpfApp.Model
{
    public class LinearFunction : Function
    {
        private static double[] _cValues = new double[] { 1, 2, 3, 4, 5 };

        public override double[] CValues => _cValues;

        public LinearFunction()
        {
            C = CValues[0];
        }

        public override double Calculate(double x, double y) => A * x + B + C;

        public override string ToString() => "Linear";
    }
}