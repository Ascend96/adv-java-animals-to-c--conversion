namespace animals_translation.Models;

public abstract class Pet
{
    protected string Name { get; set; }
    
    protected Pet(string name)
    {
        Name = name;
    }
    
}