namespace StudentLibrary.Tests;

public class StudentTests
{
    [Fact]
    public void StartDateTodayEqualsStatusNew()
    {
        // Arrange
        Student s = new Student { Id = 1, GivenName = "Lucy", SurName = "Somefing", StartDate = DateTime.Now, EndDate = new DateTime(2025, 12, 31), GraduationDate = new DateTime(2025, 12, 30) };

        // Act
        var expected = Status.New;
        var actual = s.Status;
        
        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    public void StartDateYesterdayEndDateLaterEqualsStatusActive()
    {
        //Arrange
        Student s = new Student { Id = 1, GivenName = "Byggemand", SurName = "Bob", StartDate = new DateTime(2022, 09, 8), EndDate = new DateTime(2022, 12, 30), GraduationDate = new DateTime(2022, 12, 30) };
        
        //Act
        var expected = Status.Active; 
        var actual = s.Status;

        //Assert
        actual.Should().Be(expected);

    }

    [Fact]
    public void EndDateLaterReachedBeforeGraduationDateEqualsStatusDropout()
    {
        //Arrange
        Student s = new Student { Id = 1, GivenName = "Karl", SurName = "Karlsen", StartDate = new DateTime(2021, 09, 19), EndDate = new DateTime(2022, 6, 30), GraduationDate = new DateTime(2023, 12, 30) };
        
        //Act
        var expected = Status.Dropout; 
        var actual = s.Status;

        //Assert
        actual.Should().Be(expected);
    }

    [Fact]
    public void GraduationDateYesterdayEqualsStatusGraduatied()
    {
        //Arrange
        Student s = new Student { Id = 1, GivenName = "Sofie", SurName = "Sofiesen", StartDate = new DateTime(2020, 09, 19), EndDate = new DateTime(2022, 09, 19), GraduationDate = new DateTime(2022, 09, 19) };
        
        //Act
        var expected = Status.Graduated; 
        var actual = s.Status;

        //Assert
        actual.Should().Be(expected);
    }

    [Fact]
    public void JoeExoticShouldBePrintedOutJoeExotic()
    {
        //Arrange
        Student s = new Student { Id = 1, GivenName = "Joe", SurName = "Exotic", StartDate = new DateTime(2020, 09, 19), EndDate = new DateTime(2022, 09, 19), GraduationDate = new DateTime(2022, 09, 19) };
        
        //Act
        var expected = "Id: 1, Given name: Joe, Surname: Exotic, Status: Graduated, Start date: 19-09-2020 00:00:00, End date: 19-09-2022 00:00:00, Graduation date: 19-09-2022 00:00:00";
        var actual = s.ToString();

        //Assert
        actual.Should().Be(expected);
    }
}