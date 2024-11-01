namespace Cafe;

public interface IDrinks 
{
    public List<DrinkDAO> GetDrinks();
    public DrinkDAO GetDrinkById(int id);
    public void AddDrink(DrinkDAO drinkdao);
    public void UpdateDrink(DrinkDAO drinkdao);
    public void DeleteDrink(int id);
    
}