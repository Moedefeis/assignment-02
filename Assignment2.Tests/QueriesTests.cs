namespace Assignment2.Tests;

public class QueriesTests
{
    [Fact]
    public void WizardsInventedByRowlingGivenListOfWizardsReturnsListOfWizardNames()
    {
        var wizards = WizardCollection.Create();

        List<string> expected = new()
        {
            "Harry Potter",
            "Voldemort",
            "Albus Dumbledore"
        };

        var actual = Queries.WizardsInventedByRowling(wizards);
        actual.Should().BeEquivalentTo(expected);
    }
}
