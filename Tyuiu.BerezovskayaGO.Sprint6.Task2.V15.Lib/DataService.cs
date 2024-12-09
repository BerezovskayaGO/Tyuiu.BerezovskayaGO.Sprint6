using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BerezovskayaGO.Sprint6.Task2.V15.Lib
{
    public class DataService : ISprint6Task2V15
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueWaitArray;
            int len = (stopValue - startValue) + 1;
            valueWaitArray = new double[len];
            double y;
            double a;
            double b;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                a = ((2 * Math.Sin(x)) / (3*x + 1.2)) + Math.Cos(x) - 7*x*2;
                y = Math.Round(a, 2);
                valueWaitArray[count] = y;
                count++;
            }
            return valueWaitArray;
        }
    }
}
