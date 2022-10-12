namespace IocDotnet;

public static class Ioc
{
    public static double Compute(char[] chars)
    {
        var n = chars.LongLength;
        var sumOfAllFrequencies = chars
            .Where(c => c != '\n')
            .GroupBy(c => c)
            .Select(g =>
            {
                var occurrences = g.LongCount();
                return occurrences * (occurrences - 1);
            })
            .Sum();
        return (double)sumOfAllFrequencies / (n * (n - 1));
    }
}