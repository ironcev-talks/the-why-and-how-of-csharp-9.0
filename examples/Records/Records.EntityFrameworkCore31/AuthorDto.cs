namespace Records.EntityFrameworkCore31
{
    public record AuthorDto
    (
        int Id,
        string Name,
        string LastName
    )
    {
        public AuthorDto() : this(0, null, null) { }
    };
}
