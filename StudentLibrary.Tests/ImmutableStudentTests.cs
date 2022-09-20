using StudentLibrary;

namespace StudentLibrary.Tests;

public class ImmutableImmutableStudentTests
{
    [Fact]
    public void StartDateTodayEqualsStatusNew()
    {
        // Arrange
        ImmutableStudent s = new (Id: 1, GivenName: "Lucy", SurName: "Somefing", StartDate: DateTime.Now, EndDate: new DateTime(2025, 12, 31), GraduationDate: new DateTime(2025, 12, 30));

        // Act
        var expected = Status.New;
        var actual = s.Status;

        // Assert
        expected.Should().Be(actual);
    }

    [Fact]
    public void StartDateYesterdayEndDateLaterEqualsStatusActive()
    {
        //Arrange
        ImmutableStudent s = new(Id: 1, GivenName: "Byggemand", SurName: "Bob", StartDate: new DateTime(2022, 09, 8), EndDate: new DateTime(2022, 12, 30), GraduationDate: new DateTime(2022, 12, 30));

        //Act
        var expectedStatus = Status.Active;
        var actualStatus = s.Status;

        //Assert
        expectedStatus.Should().Be(actualStatus);

    }

    [Fact]
    public void EndDateLaterReachedBeforeGraduationDateEqualsStatusDropout()
    {
        //Arrange
        ImmutableStudent s = new(Id: 1, GivenName: "Karl", SurName: "Karlsen", StartDate: new DateTime(2021, 09, 19), EndDate: new DateTime(2022, 6, 30), GraduationDate: new DateTime(2023, 12, 30));

        //Act
        var expectedStatus = Status.Dropout;
        var actualStatus = s.Status;

        //Assert
        expectedStatus.Should().Be(actualStatus);

    }

    [Fact]
    public void GraduationDateYesterdayEqualsStatusGraduated()
    {
        //Arrange
        ImmutableStudent s = new ( Id: 1, GivenName: "Sofie", SurName: "Sofiesen", StartDate: new DateTime(2020, 09, 19), EndDate: new DateTime(2022, 09, 19), GraduationDate: new DateTime(2022, 09, 19));

        //Act
        var expectedStatus = Status.Graduated;
        var actualStatus = s.Status;

        //Assert
        expectedStatus.Should().Be(actualStatus);

    }

    [Fact]
    public void JoeExoticShouldBePrintedOutJoeExotic()
    {
        //Arrange
        ImmutableStudent s = new ( Id: 1, GivenName: "Joe", SurName: "Exotic", StartDate: new DateTime(2020, 09, 19), EndDate: new DateTime(2022, 09, 19), GraduationDate: new DateTime(2022, 09, 19) );
        
        //Act
        var expectedStatus = "ImmutableStudent { Id = 1, GivenName = Joe, SurName = Exotic, StartDate = 19-09-2020 00:00:00, EndDate = 19-09-2022 00:00:00, GraduationDate = 19-09-2022 00:00:00, Status = Graduated }"; 
        var actualStatus = s.ToString();

        //Assert
        expectedStatus.Should().Be(actualStatus);

    }

    [Fact]
    public void JoeExoticShouldNotEqualJoeNonExotic()
    {
        ImmutableStudent s0 = new ( Id: 1, GivenName: "Joe", SurName: "Exotic", StartDate: new DateTime(2020, 09, 19), EndDate: new DateTime(2022, 09, 19), GraduationDate: new DateTime(2022, 09, 19) );
        ImmutableStudent s1 = new ( Id: 1, GivenName: "Joe", SurName: "NonExotic", StartDate: new DateTime(2019, 09, 19), EndDate: new DateTime(2025, 09, 19), GraduationDate: new DateTime(2025, 09, 19) );

        var expected = false;
        var actual = s0 == s1;

        actual.Should().Be(actual);
    }

    [Fact]
    public void JoeShouldEqualJoe()
    {
        ImmutableStudent s0 = new ( Id: 1, GivenName: "Joe", SurName: "Exotic", StartDate: new DateTime(2020, 09, 19), EndDate: new DateTime(2022, 09, 19), GraduationDate: new DateTime(2022, 09, 19) );
        ImmutableStudent s1 = new ( Id: 1, GivenName: "Joe", SurName: "Exotic", StartDate: new DateTime(2020, 09, 19), EndDate: new DateTime(2022, 09, 19), GraduationDate: new DateTime(2022, 09, 19) );

        var expected = true;
        var actual = s0 == s1;

        expected.Should().Be(actual);
    }
}
