namespace Cafe;

public class DrinkDAO
{
    int ID { get; set; }
    string Name { get; set; }
    double Price { get; set; }
    string Contents { get; set; }

    public static DrinkDAO CreateDrink(string name, double price, string contents)
    {
        return new DrinkDAO
        {
            Name = name,
            Price = price,
            Contents = contents
        };
    }
}

