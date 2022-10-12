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
                Ocurrences = (long)g.Count()
            });
        var sumAllFrequencies = charOccurrences
            .Select(gc => gc.Ocurrences * (gc.Ocurrences - 1))
            .Sum();
        var total = (double)sumAllFrequencies / (n * (n - 1));
        return total;
    }
}