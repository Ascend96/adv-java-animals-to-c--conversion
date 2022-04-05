namespace animals_translation.Models;

public class Teacher : Person, ITalkable
{
    private int Age { get; set; }

    public Teacher(string name, int age) : base(name)
    {
        Age = age;
        Name = name;
    }

    public string Talk()
    {
        return "Don't forget to do the assigned reading!";
        ;
    }
    
}