using System;
using System.Collections.Generic;
public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}
public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if (number <= 0)
            throw new ArgumentOutOfRangeException();
        int sum = 0;
        foreach (int i in ProperDivisor(number))
        {
            sum = sum + i;
        }
        if (sum < number)
            return Classification.Deficient;
        if (sum > number)
            return Classification.Abundant;
        return Classification.Perfect;
    }
    private static IEnumerable<int> ProperDivisor(int num)
    {
        for (int i = 1; i < num; ++i)
        {
            if (num % i == 0)
                yield return i;
        }
    }
}