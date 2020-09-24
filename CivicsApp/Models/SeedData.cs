using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CivicsApp.Data;
using System;
using System.Linq;

namespace CivicsApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RepresentativeContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RepresentativeContext>>()))
            {
                // Look for any movies.
                if (context.Representative.Any())
                {
                    return;   // DB has been seeded
                }

                context.Representative.AddRange(
                    //new Representative
                    //{
                    //    LastName = "Johnson"
                    //},

                    //new Representative
                    //{
                    //    LastName = "Smith"
                    //},

                    //new Representative
                    //{
                    //    LastName = "Jackson"
                    //},

                    //new Representative
                    //{
                    //    LastName = "Armstrong"
                    //}
                );
                context.SaveChanges();
            }
        }
    }
}