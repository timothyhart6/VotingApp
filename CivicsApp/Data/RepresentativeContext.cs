using System;
using CivicsApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CivicsApp.Data
{
    public class RepresentativeContext : DbContext
    {
        public RepresentativeContext(DbContextOptions<RepresentativeContext> options)
            :base(options)
        {
        }

        public DbSet<ListOfHouseMembers> Representative { get; set; }
    }
}
