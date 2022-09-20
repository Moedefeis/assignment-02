using System.Text;

namespace StudentLibrary;

public record ImmutableStudent(int Id, string GivenName, string SurName, DateTime StartDate, DateTime EndDate, DateTime GraduationDate)
{
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
}
