using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StudentsList.Data;
using System;
using System.Linq;

namespace StudentsList.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new StudentsListContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<StudentsListContext>>()))
            {
                // Look for any movies.
                if (context.Student.Any())
                {
                    return;   // DB has been seeded
                }

                context.Student.AddRange(
                    new Student
                    {
                        Name = "Szymon Kwaśniewski",
                        BirthDate = DateTime.Parse("2000-08-23"),
                        Subject = "Computer Science",
                        StudentNumber = 123.32m
                    },

                    new Student
                    {
                        Name = "Adam Nowak",
                        BirthDate = DateTime.Parse("1999-3-12"),
                        Subject = "Computer Science",
                        StudentNumber = 4312.23m
                    },

                    new Student
                    {
                        Name = "Anna Nowakowska",
                        BirthDate = DateTime.Parse("2001-2-13"),
                        Subject = "Business Administration",
                        StudentNumber = 7564.32m
                    },

                    new Student
                    {
                        Name = "Natalia Włodarczyk",
                        BirthDate = DateTime.Parse("2000-6-26"),
                        Subject = "Computer Science",
                        StudentNumber = 143.32m
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
