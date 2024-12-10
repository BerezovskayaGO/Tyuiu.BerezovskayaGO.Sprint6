﻿using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BerezovskayaGO.Sprint6.Task4.V19.Lib
{
    public class DataService : ISprint6Task4V19
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round((5 * x + 2.5) / (Math.Sin(x) - 2) + 2, 2);
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
