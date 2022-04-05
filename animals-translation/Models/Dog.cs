namespace animals_translation.Models;

public class Dog : Pet, ITalkable
{
    public bool IsFriendly { get; set; }

    public Dog(string name, bool isFriendly) : base(name)
    {
        IsFriendly = isFriendly;
    }

    public string Talk()
    {
        return "Bark";
    }

    public string GetName()
    {
        return "Dog: " + "name=" + Name + " friendly=" + IsFriendly;
    }
}