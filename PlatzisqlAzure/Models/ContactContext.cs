using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatzisqlAzure.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Contact> GetContacts {get; set ;}

        

    }
}
