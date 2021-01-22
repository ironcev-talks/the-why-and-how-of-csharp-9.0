using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using InitOnlySetters.EntityFrameworkCore31;

namespace TheWhyAndHowOfCSharp90
{
    public partial class Program
    {
        private static void Main()
        {
            var context = new DemoContext();
            CreateAndSeedDatabase(context, SeedDatabase);

            Console.Clear();

            DisplayDemoStep("Get authors");

            DisplayAuthorsNames(context.Authors);

            Console.ReadKey(true);

            DisplayDemoStep("Get author DTOs");

            DisplayAuthorsNames(context.Authors.Select(author => new AuthorDto
            {
                Id = author.Id,
                Name = author.FirstName
            }));
        }

        private static void DisplayAuthorsNames(IEnumerable<Author> authors)
        {
            Thread.Sleep(500); // A quick and dirty way to avoid overlapping of this and EF logging output.

            foreach (var author in authors)
                DisplayText(author.FullName);
        }

        private static void DisplayAuthorsNames(IEnumerable<AuthorDto> authors)
        {
            Thread.Sleep(500); // A quick and dirty way to avoid overlapping of this and EF logging output.

            foreach (var author in authors)
                DisplayText(author.Name);
        }

        private static void SeedDatabase(DemoContext context)
        {
            context.Authors.Add(
                new Author
                {
                    FirstName = "Ivo",
                    LastName = "Andrić"
                });

            context.Authors.Add(
                new Author
                {
                    FirstName = "Elfriede",
                    LastName = "Jelinek"
                });

            context.Authors.Add(
                new Author
                {
                    FirstName = "Juan",
                    MiddleName = "Ramón",
                    LastName = "Jiménez"
                });

            context.Authors.Add(
                new Author
                {
                    FirstName = "Rabindranath",
                    LastName = "Tagore"
                });

            context.SaveChanges();
        }
    }
}
