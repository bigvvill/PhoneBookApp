using Microsoft.EntityFrameworkCore;
using PhoneBookApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp.Data
{
    public class PhoneBookAppDbContext : DbContext
    {
        public PhoneBookAppDbContext(DbContextOptions<Contact> options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }

    
}
