namespace DotNetMasterClass.Services;

public class TimeCimplexity
{
    public static int SumOfThree(int[] numberArrays)
    {
        var length = numberArrays.Length;
        var counter = 0;

        /*! Time complexity O(n^3) */
        for (var i = 0; i < length; i++)
        {
            for (var j = i + 1; j < length; j++)
            {
                for (var k = j + 1; k < length; k++)
                {
                    if (numberArrays[i] + numberArrays[j] + numberArrays[k] == 0)
                        counter++;
                }
            }
        }

        return counter;
    }
}