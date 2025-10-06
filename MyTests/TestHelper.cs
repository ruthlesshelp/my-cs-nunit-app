namespace MyTests;

using System.Collections.ObjectModel;

internal static class TestHelper
{
    internal static int CalculateSum(ReadOnlyCollection<int> input)
    {
        int sum = 0;
        for (int i = 0; i < input.Count; i += 2)
        {
            sum += input[i] * input[i + 1];
        }

        return sum;
    }
}
