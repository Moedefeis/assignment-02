namespace Assignment2.Tests;

public class QueriesTests
{
    [Fact]
    public void WizardsInventedByRowling_given_list_of_wizards_returns_list_of_wizard_names()
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

    [Fact]
    public void WizardsInventedByRowlingLinq_given_list_of_wizards_returns_list_of_wizard_names()
    {
        var wizards = WizardCollection.Create();

        List<string> expected = new()
        {
            "Harry Potter",
            "Voldemort",
            "Albus Dumbledore"
        };

        var actual = Queries.WizardsInventedByRowlingLinq(wizards);
        actual.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void YearFirstSithLordWasIntroduced_given_list_of_wizards_returns_year()
    {
        var wizards = WizardCollection.Create();

        var expected = 1977;
        var actual = Queries.YearFirstSithLordWasIntroduced(wizards);
        actual.Should().Be(expected);
    }

    [Fact]
    public void YearFirstSithLordWasIntroducedLinq_given_list_of_wizards_returns_year()
    {
        var wizards = WizardCollection.Create();

        var expected = 1977;
        var actual = Queries.YearFirstSithLordWasIntroducedLinq(wizards);
        actual.Should().Be(expected);
    }

    [Fact]
    public void UniqueWizardsFromHarryPotterBooks_given_list_of_wizards_returns_tuples_of_Wizard_names_and_year()
    {
        var wizards = WizardCollection.Create();

        List<(string, int)> expected = new()
        {
            ("Harry Potter", 2000),
            ("Voldemort", 2000),
            ("Albus Dumbledore", 2000),
        };

        var actual = Queries.UniqueWizardsFromHarryPotterBooks(wizards);
        actual.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void UniqueWizardsFromHarryPotterBooksLinq_given_list_of_wizards_returns_tuples_of_Wizard_names_and_year()
    {
        var wizards = WizardCollection.Create();

        List<(string, int)> expected = new()
        {
            ("Harry Potter", 2000),
            ("Voldemort", 2000),
            ("Albus Dumbledore", 2000),
        };

        var actual = Queries.UniqueWizardsFromHarryPotterBooksLinq(wizards);
        actual.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void WizardNamesInReverseOrderByCreatorThenName_given_list_of_wizards_returns_list_of_wizard_names()
    {
        var wizards = WizardCollection.Create();

        List<string> expected = new()
        {
            "Stephen Strange",
            "Ice King",
            "Gandalf",
            "Sauron",
            "Albus Dumbledore",
            "Harry Potter",
            "Voldemort",
            "Darth Sidius",
            "Darth Vader",
            "Anakin Skywalker",
            "Luke Skywalker"
        };

        var actual = Queries.WizardNamesInReverseOrderByCreatorThenName(wizards);
        actual.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void WizardNamesInReverseOrderByCreatorThenNameLinq_given_list_of_wizards_returns_list_of_wizard_names()
    {
        var wizards = WizardCollection.Create();

        List<string> expected = new()
        {
            "Stephen Strange",
            "Ice King",
            "Gandalf",
            "Sauron",
            "Albus Dumbledore",
            "Harry Potter",
            "Voldemort",
            "Darth Sidius",
            "Darth Vader",
            "Anakin Skywalker",
            "Luke Skywalker"
        };

        var actual = Queries.WizardNamesInReverseOrderByCreatorThenNameLinq(wizards);
        actual.Should().BeEquivalentTo(expected);
    }
}
