using System.Data.SQLite;

namespace Cafe;

public class DrinksDatabase : IDrinks
{
    private SQLiteConnection _connection;
    public List<DrinkDAO> GetDrinks()
    {
        throw new NotImplementedException();
        
    }

    public DrinkDAO GetDrinkById(int id)
    {
        throw new NotImplementedException();
    }

    public void AddDrink(DrinkDAO drinkdao)
    {
        throw new NotImplementedException();
    }

    public void UpdateDrink(DrinkDAO drinkdao)
    {
        throw new NotImplementedException();
    }

    public void DeleteDrink(int id)
    {
        throw new NotImplementedException();
    }

    public DrinksDatabase()
    {
     _connection = new SQLiteConnection("Data Source=Cafe.db;Version=3;");   
     using (var cmd = _connection.CreateCommand())
     {
         _connection.Open();
         cmd.CommandText = @"CREATE TABLE IF NOT EXISTS Drinks (
             Id INTEGER AUTOINCREMENT PRIMARY KEY,
             Name TEXT,
             Price DOUBLE,
             Contents TEXT,                     
         )";
         cmd.ExecuteNonQuery();
     }
    }
}