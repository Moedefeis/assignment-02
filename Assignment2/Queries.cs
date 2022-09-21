namespace Assignment2;

public class Queries
{
    public static IEnumerable<string> WizardsInventedByRowling(IEnumerable<Wizard> wizards)
    {
        return from w in wizards
               where w.Creator is "%Rowling%"
               select w.Name;

    }
}
