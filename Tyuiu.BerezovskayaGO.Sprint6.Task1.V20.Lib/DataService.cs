using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BerezovskayaGO.Sprint6.Task1.V20.Lib
{
    public class DataService : ISprint6Task1V20
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
                a = ((2 * x - 3) / (Math.Cos(x) - 2 * x)) + 5 * x - Math.Sin(x);
                y = Math.Round(a, 2);
                valueWaitArray[count] = y;
                count++;
            }
            return valueWaitArray;
        }
    }
}
