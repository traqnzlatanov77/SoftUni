﻿using System;

class HalfSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int firstSum = 0;
        int secondSum = 0;
        for (int i = 0; i < n; i++)
        {
            firstSum += int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            secondSum += int.Parse(Console.ReadLine());
        }
        if (Math.Abs(firstSum - secondSum) == 0)
        {
            Console.WriteLine("Yes, sum={0}", firstSum);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(firstSum - secondSum));
        }
    }
}
