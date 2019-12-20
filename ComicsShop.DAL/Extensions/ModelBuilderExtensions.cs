using Microsoft.EntityFrameworkCore;
using PublishingHouse.DAL.Entities;
using PublishingHouse.DAL.EntityConfigurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace PublishingHouse.DAL.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void SetConfigurations(this ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AuthorConfiguration());
            modelBuilder.ApplyConfiguration(new BookAuthorConfiguration());
            modelBuilder.ApplyConfiguration(new BookCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new BookConfiguration());
            modelBuilder.ApplyConfiguration(new BookOrderConfiguration());
            modelBuilder.ApplyConfiguration(new CartConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CommentConfiguration());
            modelBuilder.ApplyConfiguration(new NotificationConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
        }

        public static void Seed(this ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Category>()
                .HasData(
                    new Category
                    {
                        Id = 1,
                        Name = "Marvel"
                    },
                    new Category
                    {
                        Id = 2,
                        Name = "DC"
                    }
                );
            modelBuilder.Entity<Author>()
                .HasData(
                    new Author
                    {
                        Id = 1,
                        Name = "Name1"
                    },
                    new Author
                    {
                        Id = 2,
                        Name = "Name2"
                    },
                    new Author
                    {
                        Id = 3,
                        Name = "Name3"
                    },
                    new Author
                    {
                        Id = 4,
                        Name = "Name4"
                    },
                    new Author
                    {
                        Id = 5,
                        Name = "Name5"
                    },
                    new Author
                    {
                        Id = 6,
                        Name = "Name6"
                    },
                    new Author
                    {
                        Id = 7,
                        Name = "Name7"
                    },
                    new Author
                    {
                        Id = 8,
                        Name = "Name8"
                    },
                    new Author
                    {
                        Id = 9,
                        Name = "Name9"
                    },
                    new Author
                    {
                        Id = 10,
                        Name = "Name10"
                    }
                );
            modelBuilder.Entity<Book>()
                .HasData(
                    new Book
                    {
                        Id = 1,
                        Title = "Marvel1",
                        ImageUrl = "~/images/Marvel.png",
                        Language = "Eng",
                        Year = 2016,
                        Format = "70х100/16 ",
                        Cover = "Soft",
                        PagesAmount = 50,
                        Description = "Some Description 1",
                        Price = 130
                    },
                    new Book
                    {
                        Id = 2,
                        Title = "Marvel2",
                        ImageUrl = "~/images/Marvel.png",
                        Language = "Ukrainian",
                        Year = 2018,
                        Format = "60х90/16",
                        Cover = "Hard",
                        PagesAmount = 40,
                        Description = "Some Description 2",
                        Price = 100
                    },
                    new Book
                    {
                        Id = 3,
                        Title = "DC1",
                        ImageUrl = "~/images/DC.png",
                        Language = "Ukrainian",
                        Year = 2018,
                        Format = "60х90/16",
                        Cover = "Hard",
                        PagesAmount = 40,
                        Description = "Some Description 3",
                        Price = 105
                    },
                    new Book
                    {
                        Id = 4,
                        Title = "DC2",
                        ImageUrl = "~/images/DC.png",
                        Language = "Eng",
                        Year = 2016,
                        Format = "70х100/16 ",
                        Cover = "Soft",
                        PagesAmount = 50,
                        Description = "Some Description 4",
                        Price = 120
                    },
                    new Book
                    {
                        Id = 5,
                        Title = "Marvel1",
                        ImageUrl = "~/images/Marvel.png",
                        Language = "Eng",
                        Year = 2016,
                        Format = "70х100/16 ",
                        Cover = "Soft",
                        PagesAmount = 50,
                        Description = "Some Description 1",
                        Price = 130
                    },
                    new Book
                    {
                        Id = 6,
                        Title = "Marvel2",
                        ImageUrl = "~/images/Marvel.png",
                        Language = "Ukrainian",
                        Year = 2018,
                        Format = "60х90/16",
                        Cover = "Hard",
                        PagesAmount = 40,
                        Description = "Some Description 2",
                        Price = 100
                    },
                    new Book
                    {
                        Id = 7,
                        Title = "DC1",
                        ImageUrl = "~/images/DC.png",
                        Language = "Ukrainian",
                        Year = 2018,
                        Format = "60х90/16",
                        Cover = "Hard",
                        PagesAmount = 40,
                        Description = "Some Description 3",
                        Price = 105
                    },
                    new Book
                    {
                        Id = 8,
                        Title = "DC2",
                        ImageUrl = "~/images/DC.png",
                        Language = "Eng",
                        Year = 2016,
                        Format = "70х100/16 ",
                        Cover = "Soft",
                        PagesAmount = 50,
                        Description = "Some Description 4",
                        Price = 120
                    },
                    new Book
                    {
                        Id = 9,
                        Title = "Marvel1",
                        ImageUrl = "~/images/Marvel.png",
                        Language = "Eng",
                        Year = 2016,
                        Format = "70х100/16 ",
                        Cover = "Soft",
                        PagesAmount = 50,
                        Description = "Some Description 1",
                        Price = 130
                    },
                    new Book
                    {
                        Id = 10,
                        Title = "Marvel2",
                        ImageUrl = "~/images/Marvel.png",
                        Language = "Ukrainian",
                        Year = 2018,
                        Format = "60х90/16",
                        Cover = "Hard",
                        PagesAmount = 40,
                        Description = "Some Description 2",
                        Price = 100
                    },
                    new Book
                    {
                        Id = 11,
                        Title = "DC1",
                        ImageUrl = "~/images/DC.png",
                        Language = "Ukrainian",
                        Year = 2018,
                        Format = "60х90/16",
                        Cover = "Hard",
                        PagesAmount = 40,
                        Description = "Some Description 3",
                        Price = 105
                    },
                    new Book
                    {
                        Id = 12,
                        Title = "DC2",
                        ImageUrl = "~/images/DC.png",
                        Language = "Eng",
                        Year = 2016,
                        Format = "70х100/16 ",
                        Cover = "Soft",
                        PagesAmount = 50,
                        Description = "Some Description 4",
                        Price = 120
                    },
                    new Book
                    {
                        Id = 13,
                        Title = "Marvel1",
                        ImageUrl = "~/images/Marvel.png",
                        Language = "Eng",
                        Year = 2016,
                        Format = "70х100/16 ",
                        Cover = "Soft",
                        PagesAmount = 50,
                        Description = "Some Description 1",
                        Price = 130
                    },
                    new Book
                    {
                        Id = 14,
                        Title = "Marvel2",
                        ImageUrl = "~/images/Marvel.png",
                        Language = "Ukrainian",
                        Year = 2018,
                        Format = "60х90/16",
                        Cover = "Hard",
                        PagesAmount = 40,
                        Description = "Some Description 2",
                        Price = 100
                    },
                    new Book
                    {
                        Id = 15,
                        Title = "DC1",
                        ImageUrl = "~/images/DC.png",
                        Language = "Ukrainian",
                        Year = 2018,
                        Format = "60х90/16",
                        Cover = "Hard",
                        PagesAmount = 40,
                        Description = "Some Description 3",
                        Price = 105
                    },
                    new Book
                    {
                        Id = 16,
                        Title = "DC2",
                        ImageUrl = "~/images/DC.png",
                        Language = "Eng",
                        Year = 2016,
                        Format = "70х100/16 ",
                        Cover = "Soft",
                        PagesAmount = 50,
                        Description = "Some Description 4",
                        Price = 120
                    }
                );
            modelBuilder.Entity<BookAuthor>()
                .HasData(
                    new BookAuthor
                    {
                        Id = 1,
                        BookId = 1,
                        AuthorId = 1
                    },
                    new BookAuthor
                    {
                        Id = 2,
                        BookId = 2,
                        AuthorId = 2
                    },
                    new BookAuthor
                    {
                        Id = 3,
                        BookId = 3,
                        AuthorId = 3
                    },
                    new BookAuthor
                    {
                        Id = 4,
                        BookId = 4,
                        AuthorId = 3
                    },
                    new BookAuthor
                    {
                        Id = 5,
                        BookId = 5,
                        AuthorId = 4
                    },
                    new BookAuthor
                    {
                        Id = 6,
                        BookId = 6,
                        AuthorId = 4
                    },
                    new BookAuthor
                    {
                        Id = 7,
                        BookId = 7,
                        AuthorId = 5
                    },
                    new BookAuthor
                    {
                        Id = 8,
                        BookId = 8,
                        AuthorId = 5
                    },
                    new BookAuthor
                    {
                        Id = 9,
                        BookId = 9,
                        AuthorId = 6
                    },
                    new BookAuthor
                    {
                        Id = 10,
                        BookId = 10,
                        AuthorId = 7
                    },
                    new BookAuthor
                    {
                        Id = 11,
                        BookId = 11,
                        AuthorId = 8
                    },
                    new BookAuthor
                    {
                        Id = 12,
                        BookId = 12,
                        AuthorId = 9
                    },
                    new BookAuthor
                    {
                        Id = 13,
                        BookId = 13,
                        AuthorId = 10
                    },
                    new BookAuthor
                    {
                        Id = 14,
                        BookId = 14,
                        AuthorId = 10
                    },
                    new BookAuthor
                    {
                        Id = 15,
                        BookId = 15,
                        AuthorId = 10
                    },
                    new BookAuthor
                    {
                        Id = 16,
                        BookId = 16,
                        AuthorId = 10
                    }
                );
            modelBuilder.Entity<BookCategory>()
                .HasData(
                    new BookCategory
                    {
                        Id = 1,
                        BookId = 1,
                        CategoryId = 1
                    },
                    new BookCategory
                    {
                        Id = 2,
                        BookId = 2,
                        CategoryId = 1
                    },
                    new BookCategory
                    {
                        Id = 3,
                        BookId = 3,
                        CategoryId = 2
                    },
                    new BookCategory
                    {
                        Id = 4,
                        BookId = 4,
                        CategoryId = 2
                    },
                    new BookCategory
                    {
                        Id = 5,
                        BookId = 5,
                        CategoryId = 1
                    },
                    new BookCategory
                    {
                        Id = 6,
                        BookId = 6,
                        CategoryId = 1
                    },
                    new BookCategory
                    {
                        Id = 7,
                        BookId = 7,
                        CategoryId = 2
                    },
                    new BookCategory
                    {
                        Id = 8,
                        BookId = 8,
                        CategoryId = 2
                    },
                    new BookCategory
                    {
                        Id = 9,
                        BookId = 9,
                        CategoryId = 1
                    },
                    new BookCategory
                    {
                        Id = 10,
                        BookId = 10,
                        CategoryId = 1
                    },
                    new BookCategory
                    {
                        Id = 11,
                        BookId = 11,
                        CategoryId = 2
                    },
                    new BookCategory
                    {
                        Id = 12,
                        BookId = 12,
                        CategoryId = 2
                    },
                    new BookCategory
                    {
                        Id = 13,
                        BookId = 13,
                        CategoryId = 1
                    },
                    new BookCategory
                    {
                        Id = 14,
                        BookId = 14,
                        CategoryId = 1
                    },
                    new BookCategory
                    {
                        Id = 15,
                        BookId = 15,
                        CategoryId = 2
                    },
                    new BookCategory
                    {
                        Id = 16,
                        BookId = 16,
                        CategoryId = 2
                    }
                );
        }
    }
}
