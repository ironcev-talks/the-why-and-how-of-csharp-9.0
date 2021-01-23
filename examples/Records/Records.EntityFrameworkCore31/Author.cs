namespace Records.EntityFrameworkCore31
{
    public record Author
    (
        int Id,
        string FirstName,
        string MiddleName,
        string LastName
    )
    {
        public Author() : this(0, null, null, null) { }

        public string FullName => ((FirstName + " " + MiddleName).Trim() + " " + LastName).Trim();
    };
}
