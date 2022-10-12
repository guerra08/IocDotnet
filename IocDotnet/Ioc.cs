namespace IocDotnet;

public static class Ioc
{
    public static double Compute(char[] chars)
    {
        var n = chars.LongLength;
        var charOccurrences = chars
            .Where(c => c != '\n')
            .GroupBy(c => c)
            .Select(g => new
            {
                Character = g.Key,
                Ocurrences = g.LongCount()
            });
        var sumAllFrequencies = charOccurrences
            .Select(gc => gc.Ocurrences * (gc.Ocurrences - 1))
            .Sum();
        return (double)sumAllFrequencies / (n * (n - 1));
    }
}