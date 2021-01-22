namespace InitOnlySetters.EntityFrameworkCore31
{
    public class Author
    {
        public int Id { get; init; }

        public string FirstName { get; init; }

        public string MiddleName { get; init; }

        public string LastName { get; init; }

        public string FullName => ((FirstName + " " + MiddleName).Trim() + " " + LastName).Trim();
    }
}
