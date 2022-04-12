using System;
using Microsoft.EntityFrameworkCore;

namespace ContactManager.Models
{
	public class ContactContext : DbContext
	{

        public ContactContext(DbContextOptions<ContactContext> options) : base(options) { }

		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Family" },
                new Category { CategoryId = 2, Name = "Friend" },
                new Category { CategoryId = 3, Name = "Work" },
                new Category { CategoryId = 4, Name = "Other" }
            );

            modelBuilder.Entity<Contact>().HasData(
                new Contact { CategoryId = 1, fname = "Noor", lname = "Said", phone = "416-222-0090", email = "noor.said@gmail.com", organization = "Organize", date_added = DateTime.Now, ContactId = 1001 },
                new Contact { CategoryId = 2, fname = "Soreti", lname = "Abbas", phone = "416-654-2253", email = "soreti.abbas@gmail.com", organization = "Sporting Goods", date_added = DateTime.Now, ContactId = 1002 },
                new Contact { CategoryId = 3, fname = "Ranya", lname = "Abdulwah", phone = "514-469-4968", email = "soreti.abdulwah@gmail.com", organization = "Monkland", date_added = DateTime.Now, ContactId = 1003 },
                new Contact { CategoryId = 4, fname = "Ibsitu", lname = "Aba Tamam", phone = "514-269-5836", email = "ibsitu.abatamam@gmail.com", organization = "Organize", date_added = DateTime.Now, ContactId = 1004 }

            );

        }


	}
}

