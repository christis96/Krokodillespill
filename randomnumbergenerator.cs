namespace Krokodillespill;

public class generator
{
    Random rand = new Random();

    public int GetRandomNumber()
    {
        return rand.Next(1, 11); 
    }
}