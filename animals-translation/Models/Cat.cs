namespace animals_translation.Models;

public class Cat : Pet, ITalkable
{

    private int MousesKilled { get; set; }


    public string Talk()
    {
        return "Meow";
    }

    public string GetName()
    {
        return "Cat: " + "name=" + Name + " mousesKilled=" + MousesKilled;
    }

    public void AddMouse()
    {
        MousesKilled++;
    }

    public Cat(string name, int mousesKilled) : base(name)
    {
        Name = name;
        MousesKilled = mousesKilled;
    }
}