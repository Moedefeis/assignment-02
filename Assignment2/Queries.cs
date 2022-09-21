namespace Assignment2;

public class Queries
{
    public static IEnumerable<string> WizardsInventedByRowling(IEnumerable<Wizard> wizards) => 
        wizards.Where(w => w.Creator == "J.K. Rowling").Select(w => w.Name);
    
    public static IEnumerable<string> WizardsInventedByRowlingLinq(IEnumerable<Wizard> wizards) => 
        from w in wizards 
        where w.Creator == "J.K. Rowling" 
        select w.Name;

    public static int? YearFirstSithLordWasIntroduced(IEnumerable<Wizard> wizards) =>
        wizards.Where(w => w.Name.Contains("Darth")).Select(w => w.Year).Min();

    public static int? YearFirstSithLordWasIntroducedLinq(IEnumerable<Wizard> wizards) =>
        (from w in wizards
        where w.Name.Contains("Darth")
        select w.Year).Min();

    public static IEnumerable<(string, int?)> UniqueWizardsFromHarryPotterBooks(IEnumerable<Wizard> wizards) =>
        wizards.Where(w => w.Medium.Contains("Harry Potter")).Select(w => (w.Name, w.Year)).Distinct();

    public static IEnumerable<(string, int?)> UniqueWizardsFromHarryPotterBooksLinq(IEnumerable<Wizard> wizards) =>
        (from w in wizards
         where w.Medium.Contains("Harry Potter")
         select (w.Name, w.Year)).Distinct();

    public static IEnumerable<string> WizardNamesInReverseOrderByCreatorThenName(IEnumerable<Wizard> wizards) =>
        wizards.OrderByDescending(w => w.Creator).ThenBy(w => w.Name).Select(w => w.Name);

    public static IEnumerable<string> WizardNamesInReverseOrderByCreatorThenNameLinq(IEnumerable<Wizard> wizards) =>
        from w in wizards
        orderby w.Creator descending
        orderby w.Name
        select w.Name;
}
