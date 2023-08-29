namespace Example1;

public class FoodTray
{
    public List<Food> Whiskas { get; }

    public FoodTray()
    {
        Whiskas = new List<Food>();
    }
    
    public bool GetWhiskas()
    {
        var count = Whiskas.Count;
        if (count > 0)
        {
            Whiskas.RemoveAt(count-1);
        }

        return true;
    }
}