namespace Krokodillespill;

public class comparer
{
    public string GetComparisonSymbol(int a, int b)
    {
        if (a < b) return "<";
        else if (a > b) return ">";
        else return "=";
    }
}