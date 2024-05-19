namespace DotNetMasterClass.Services;

public class ReadIntegers
{
    public static IEnumerable<int> ReadInts(string filePath)
    {
        using TextReader reader = File.OpenText(filePath);
        while (reader.ReadLine() is { } lastLine)
        {
            yield return int.Parse(lastLine);
        }
    }
}