using Example1;

var cat = new Cat("Ginger");
var host = new Host("Andrei");
var foodTray = new FoodTray();

// Кошка кушает whiskas из лотка для еды
while (cat.IsHungry())
{
    if(foodTray.Whiskas.Count == 0)
        host.AddFood(foodTray);
    
    cat.Eat(foodTray.GetWhiskas());
}

Console.WriteLine("Кошка не голодная!");