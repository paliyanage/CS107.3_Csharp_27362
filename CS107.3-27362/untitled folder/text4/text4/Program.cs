﻿static void Main(string[] arggs)
{
    int[,] num = { { 10, 20 }, { 23, 43 } };

    int min = num[0, 0];
    int max = num[0, 0];

    for (int i = 0; i < 2; i++)
    {
        for(int j = 0; j<2; j++)
        {
            if (num[i, j] < min)
            {
                min = num[i, j];
            }

            if (num[i, j] > max)
            {
                max = num[i, j];
            }
        }
    }
    Console.WriteLine("Min :" + min);
    Console.WriteLine("Max :" + max);

}
