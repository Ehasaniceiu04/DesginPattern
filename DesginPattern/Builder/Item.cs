namespace Builder
{
    public interface Item
    {
        string Name { get; }
        float Price { get; }
        Packing packing { get; }
    }


    public class VegBurger : Item
    {
        string Item.Name => "Beef Burger";

        float Item.Price => 100.0f;

        Packing Item.packing => new Wrapper();
    }
    public class NonVegBurger : Item
    {
        string Item.Name => "Beef Burger";

        float Item.Price => 110.0f;

        Packing Item.packing => new Wrapper();
    }
    public class Pepsi : Item
    {
        string Item.Name => "Pepsi";

        float Item.Price => 25.0f;

        Packing Item.packing => new Bottle();
    }
    public class Coke : Item
    {
        string Item.Name => "Coke";

        float Item.Price => 20.0f;

        Packing Item.packing => new Bottle();
    }

}