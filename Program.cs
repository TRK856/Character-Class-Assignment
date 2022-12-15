// See https://aka.ms/new-console-template for more information
#nullable disable
List<Character> characters = new List<Character>()
{
    new Character("Kung Fu Panda", "Skadoosh", "You have been blinded by pure awesomeness!"),
    new Character(
        "Spiderman",
        "My Spider-Sense is tingling",
        "Your friendly neighbourhood spiderman."
    )
};

// example
Console.Clear();
characters[0].Speak(1);
characters[1].SetLevel(2);
characters[1].Speak(2);

// character class
public class Character
{
    public string Name;
    public string Phrase1;
    public string Phrase2;
    public int Level = 0;

    public Character(string name, string p1, string p2)
    {
        this.Name = name;
        this.Phrase1 = p1;
        this.Phrase2 = p2;
    }

    public void Speak(int phraseNum)
    {
        if (phraseNum == 1)
        {
            Console.WriteLine(this.Phrase1);
        }
        else if (phraseNum == 2)
        {
            Console.WriteLine(this.Phrase2);
        }
    }

    public void SetLevel(int newLevel)
    {
        this.Level = newLevel;
        Console.WriteLine("Level: {0}", newLevel);
    }
}
