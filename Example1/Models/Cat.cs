namespace Example1;

public class Cat
{
    private readonly string _name;
    private int _hunger;
    private readonly Random _rnd;

    public Cat(string name)
    {
        _rnd = new Random();
        _name = name;
        _hunger = 100;
    }
    
    // Кошка ест еду
    public void Eat(bool haveFood)
    {
        _hunger -= _rnd.Next(1, 10);
       
        Console.WriteLine($"Кошка {_name} ест.");
    }

    public bool IsHungry()
    {
        return _hunger > 50;
    }
}