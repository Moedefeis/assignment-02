using System.Text;

namespace StudentLibrary;

public class Student
{
    public int Id { get; init; }
    public string? GivenName { get; set; }
    public string? SurName { get; set; }
    private Status _status;
    public Status Status 
    { 
        get 
        {
            if (StartDate.AddDays(10) >= DateTime.Now)
            {
                _status = Status.New;
            } 
            else if (EndDate > DateTime.Now) 
            {
                _status = Status.Active;
            } 
            else if (DateTime.Now >= EndDate && EndDate != GraduationDate) 
            {
                _status = Status.Dropout;
            } 
            else
            {
                _status = Status.Graduated;
            }

            return _status;
        } 
    }
    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }
    public DateTime GraduationDate { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("Id: ").Append(Id).Append(", Given name: ").Append(GivenName).Append(", Surname: ")
            .Append(SurName).Append(", Status: ").Append(Status).Append(", Start date: ").Append(StartDate)
            .Append(", End date: ").Append(EndDate).Append(", Graduation date: ").Append(GraduationDate);
        return sb.ToString();
    }
}