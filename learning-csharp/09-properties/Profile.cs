public class Profile
{
    public string Name
    {
        get;
        set
        {
            if (value.Length >= 3)
            {
                field = value;
            }
        }
    }
    
    public int Level { get; private set; }

    private int experience;
    public int Experience => experience;

    public string Status { get; set; }
    public string DisplayHeader => $"{Name} (Level {Level})\n💬 {Status}";

    public void AddExperience(int exp)
    {
        experience += exp;

        Level = experience / 1000;
    }
}