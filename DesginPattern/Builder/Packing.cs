namespace Builder
{
    public interface Packing
    {
        string Pack();
    }
    public class Wrapper : Packing
    {
        string Packing.Pack()
        {
            return "Wrapper";
        }
    }
    public class Bottle : Packing
    {
        string Packing.Pack()
        {
            return "Bottle";
        }
    }
}