namespace Example1;

public class Host
{
    private readonly Random _rnd;
    public string Name { get; }

    public Host(string name)
    {
        _rnd = new Random();
        Name = name;
    }

    public void AddFood(FoodTray tray)
    {
        var portion = _rnd.Next(1, 5);
        var newFood = new List<Food>();
        for (var i = 0; i < portion; i++)
        {
            newFood.Add(new Food("Whiskas"));
        }
        
        tray.Whiskas.AddRange(newFood);
    }
}