using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ContactsWebApp.Models;

namespace ContactsWebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ContactsWebApp.Models.Account> Account { get; set; }
        public DbSet<ContactsWebApp.Models.Contacts> Contacts { get; set; }
    }
}
