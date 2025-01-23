using ContactManagerApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactManagerApi.Data
{
    public class ContactDBContext : DbContext
    {
        public ContactDBContext(DbContextOptions<ContactDBContext> options) : base(options)
        {
        }
        public DbSet<Contact> Contacts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(
                new Contact { Id = 3, Name = "John Doe", Phone = "1234567890", Email = "johndoe@example.com", Address = "123 Main St", City = "Los Angeles", State = "CA", PostalCode = "90001" },
                new Contact { Id = 4, Name = "Jane Smith", Phone = "9876543210", Email = "janesmith@example.com", Address = "456 Elm St", City = "San Francisco", State = "CA", PostalCode = "94101" },
                new Contact { Id = 5, Name = "Alice Johnson", Phone = "5551234567", Email = "alicej@example.com", Address = "789 Oak St", City = "Seattle", State = "WA", PostalCode = "98101" },
                new Contact { Id = 6, Name = "Bob Brown", Phone = "4445556666", Email = "bobb@example.com", Address = "321 Pine St", City = "Denver", State = "CO", PostalCode = "80201" },
                new Contact { Id = 7, Name = "Emma Davis", Phone = "2223334444", Email = "emmad@example.com", Address = "654 Cedar Ave", City = "Chicago", State = "IL", PostalCode = "60601" },
                new Contact { Id = 8, Name = "William Wilson", Phone = "1112223333", Email = "williamw@example.com", Address = "987 Birch Rd", City = "Austin", State = "TX", PostalCode = "73301" },
                new Contact { Id = 9, Name = "Olivia Martinez", Phone = "9998887777", Email = "oliviam@example.com", Address = "123 Maple Blvd", City = "Miami", State = "FL", PostalCode = "33101" },
                new Contact { Id = 10, Name = "James Anderson", Phone = "8887776666", Email = "jamesa@example.com", Address = "456 Spruce Ln", City = "Boston", State = "MA", PostalCode = "02101" },
                new Contact { Id = 11, Name = "Sophia Garcia", Phone = "7776665555", Email = "sophiag@example.com", Address = "789 Willow Dr", City = "Phoenix", State = "AZ", PostalCode = "85001" },
                new Contact { Id = 12, Name = "Michael Hernandez", Phone = "6665554444", Email = "michaelh@example.com", Address = "321 Aspen Way", City = "Las Vegas", State = "NV", PostalCode = "89101" }
            );
        }
    }
}