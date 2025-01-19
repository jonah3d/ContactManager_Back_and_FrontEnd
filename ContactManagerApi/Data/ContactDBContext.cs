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
    }

    }
