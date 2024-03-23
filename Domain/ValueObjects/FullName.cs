namespace Domain.ValueObjects;
/// <summary>
/// TODO: Описать
/// </summary>
public class FullName : BaseValueObject
{
    public FullName(string firstName, string lastName, string middleName)
    {
        FirstName = firstName;
        LastName = lastName;
        MiddleName = middleName;
    }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? MiddleName { get; set; } = null;
}