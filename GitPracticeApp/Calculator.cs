namespace GitPracticeApp
{
    public static class Calculator
    {
        public static int Multiply(int a, int b) => a * b;
        public static double Divide(double a, double b) => b != 0 ? a / b : 0;
    }
}
