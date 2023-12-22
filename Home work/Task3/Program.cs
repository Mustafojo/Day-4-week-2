var aut = new Author();
aut.Name = "Mustafo";
aut.Age = 16;
aut.Nationality = "Tajikistan";

System.Console.WriteLine(aut.Introduce());

public class Author
{
    public string Name;
    public int Age;
    public string Nationality;

    public string GetName()
    {
        return $"{Name}";
    }
    public string GetAge()
    {
        return $"{Age}";
    }
    public string GetNationality()
    {
        return $"{Nationality}";
    }

    public string Introduce()
    {
        return $"Номи ман {Name}.Ман {Age} сола ҳастам. Ман аз {Nationality} ҳастам.";
    }
    public string CelebrateBirthday()
    {
        return $"{Age + 1}";
    }
}