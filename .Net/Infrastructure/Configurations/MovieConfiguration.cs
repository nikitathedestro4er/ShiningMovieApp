using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Infrastructure.Configurations
{
    internal sealed class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.ToTable(nameof(Movie));


            builder.HasKey(movie => movie.Id);
            

            builder.Property(movie => movie.Id).ValueGeneratedOnAdd();


            builder.Property(movie => movie.Name).IsRequired().HasMaxLength(50);


            builder.Property(movie => movie.DirectorId).IsRequired();


            builder.HasOne(movie => movie.Director).WithMany(director => director.Movies).HasForeignKey(movie => movie.DirectorId);


            builder.Property(movie => movie.GenreId).IsRequired();


            builder.HasOne(movie => movie.Genre).WithMany(genre => genre.Movies).HasForeignKey(movie => movie.GenreId);


            builder.Property(movie => movie.Image).IsRequired();


            builder.Property(movie => movie.Year).IsRequired();


            builder.Property(movie => movie.Rating).IsRequired();


            builder.Property(movie => movie.Length).IsRequired().HasColumnType("time(0)");


            builder.Property(movie => movie.Description).IsRequired().HasMaxLength(500);


            builder.Property(movie => movie.CreationTime).IsRequired();


            builder.Property(movie => movie.ModifiedDate).IsRequired();


            builder.HasData(
                new Movie
                {
                    Id = 1,
                    Name = "Shining",
                    GenreId = 1,
                    DirectorId = 1,
                    Rating = 10.9,
                    Image = "Shining--216171b4-557f-498b-97fb-89265e2f6976.jpg",
                    Year = 1980,
                    Length = new TimeSpan(2, 26, 00),
                    Description = "A family heads to an isolated hotel for the winter where a sinister presence influences the father into violence, while his psychic son sees horrific forebodings from both past and future."
                },
                new Movie
                {
                    Id = 2,
                    Name = "2001: A Space Odyssey",
                    GenreId = 3,
                    DirectorId = 1,
                    Rating = 10.2,
                    Image = "2001 A Space Odyssey--4bb2a106-b137-4c41-b87d-ad78bc617c44.jpg",
                    Year = 1968,
                    Length = new TimeSpan(2, 29, 00),
                    Description = "The Monoliths push humanity to reach for the stars; after their discovery in Africa generations ago, the mysterious objects lead mankind on an awesome journey to Jupiter, with the help of H...."
                },
                new Movie
                {
                    Id = 3,
                    Name = "The Dark Knight",
                    GenreId = 2,
                    DirectorId = 2,
                    Rating = 9.8,
                    Image = "The Dark Knight--843dd091-41c3-48dd-8c87-ffd116d4a2db.jpg",
                    Year = 2008,
                    Length = new TimeSpan(2, 32, 00),
                    Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice."
                },
                new Movie
                {
                    Id = 4,
                    Name = "Inception",
                    GenreId = 3,
                    DirectorId = 2,
                    Rating = 11.1,
                    Image = "Inception--c41f5f44-f7d1-4f5a-b9d2-f76006150c35.jpg",
                    Year = 2010,
                    Length = new TimeSpan(2, 28, 00),
                    Description = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O., but his tragic past may doom the pro..."
                },
                new Movie
                {
                    Id = 5,
                    Name = "Lock, Stock and Two Smoking Barrels",
                    GenreId = 2,
                    DirectorId = 3,
                    Rating = 11.0,
                    Image = "Lock, Stock and Two Smoking Barrels--dd1478a7-0f13-4795-a455-d8ba9b19e4df.jpg",
                    Year = 1998,
                    Length = new TimeSpan(1, 47, 00),
                    Description = "Eddy persuades his three pals to pool money for a vital poker game against a powerful local mobster, Hatchet Harry. Eddy loses, after which Harry gives him a week to pay back 500,000 pounds."
                },
                new Movie
                {
                    Id = 6,
                    Name = "Sherlock Holmes",
                    GenreId = 4,
                    DirectorId = 3,
                    Rating = 9.7,
                    Image = "Sherlock Holmes--7cdcdde5-876c-4694-b9e7-2ce7978d6c04.jpg",
                    Year = 2009,
                    Length = new TimeSpan(2, 8, 00),
                    Description = "Detective Sherlock Holmes and his stalwart partner Watson engage in a battle of wits and brawn with a nemesis whose plot is a threat to all of England."
                },
                new Movie
                {
                    Id = 7,
                    Name = "Django Unchained",
                    GenreId = 6,
                    DirectorId = 4,
                    Rating = 11.0,
                    Image = "Django Unchained--ff44c1db-aeca-42d0-9c54-6262b4524d79.jpg",
                    Year = 2012,
                    Length = new TimeSpan(2, 45, 00),
                    Description = "With the help of a German bounty-hunter, a freed slave sets out to rescue his wife from a brutal plantation-owner in Mississippi."
                },
                new Movie
                {
                    Id = 8,
                    Name = "The Hatefull Eight",
                    GenreId = 6,
                    DirectorId = 4,
                    Rating = 10.0,
                    Image = "The Hatefull Eight--430c1969-55b9-46c5-92ef-eb511f72a4e3.jpg",
                    Year = 2015,
                    Length = new TimeSpan(2, 48, 00),
                    Description = "In the dead of a Wyoming winter, a bounty hunter and his prisoner find shelter in a cabin currently inhabited by a collection of nefarious characters."
                },
                new Movie
                {
                    Id = 9,
                    Name = "Taxi",
                    GenreId = 5,
                    DirectorId = 5,
                    Rating = 10.5,
                    Image = "Taxi--730f60f3-73b5-4411-a970-ed5589c3af85.jpg",
                    Year = 1998,
                    Length = new TimeSpan(1, 26, 00),
                    Description = "To work off his tarnished driving record, a hip taxi driver must chauffeur a loser police inspector on the trail of German bank robbers."
                },
                new Movie
                {
                    Id = 10,
                    Name = "The Family",
                    GenreId = 5,
                    DirectorId = 5,
                    Rating = 9.7,
                    Image = "The Family--b7bd1a39-9063-4a47-b7a2-117da0e272da.jpg",
                    Year = 2013,
                    Length = new TimeSpan(1, 51, 00),
                    Description = "The Manzoni family, a notorious mafia clan, is relocated to Normandy, France under the Witness Protection Program, where fitting in soon becomes challenging, as their old habits die hard."
                },
                new Movie
                {
                    Id = 11,
                    Name = "Léon: The Professional",
                    GenreId = 2,
                    DirectorId = 5,
                    Rating = 10.9,
                    Image = "Leon The Professional--7619839c-e7ad-4e0a-af43-5e862b840725.jpg",
                    Year = 1994,
                    Length = new TimeSpan(1, 50, 00),
                    Description = "Mathilda, a 12-year-old girl, is reluctantly taken in by Léon, a professional assassin, after her family is murdered. An unusual relationship forms as she becomes his protégée and learns the..."
                },
                new Movie
                {
                    Id = 12,
                    Name = "The Prestige",
                    GenreId = 4,
                    DirectorId = 2,
                    Rating = 10.2,
                    Image = "The Prestige--b52f0f04-d67a-442e-8853-60667d5ff871.jpg",
                    Year = 2006,
                    Length = new TimeSpan(2, 10, 00),
                    Description = "After a tragic accident, two stage magicians in 1890s London engage in a battle to create the ultimate illusion while sacrificing everything they have to outwit each other."
                },
                new Movie
                {
                    Id = 13,
                    Name = "Shutter Island",
                    GenreId = 1,
                    DirectorId = 6,
                    Rating = 10.4,
                    Image = "Shutter Island--90fea998-b36e-41cf-be61-d62a95eec933.jpg",
                    Year = 2010,
                    Length = new TimeSpan(2, 18, 00),
                    Description = "In 1954, a U.S. Marshal investigates the disappearance of a murderer who escaped from a hospital for the criminally insane."
                },
                new Movie
                {
                    Id = 14,
                    Name = "It",
                    GenreId = 1,
                    DirectorId = 7,
                    Rating = 10.0,
                    Image = "It--11df08d0-fb79-4999-8167-9fd1e5913fb8.jpg",
                    Year = 2017,
                    Length = new TimeSpan(2, 15, 00),
                    Description = "In the summer of 1989, a group of bullied kids band together to destroy a shape-shifting monster, which disguises itself as a clown and preys on the children of Derry, their small Maine town..."
                },
                new Movie
                {
                    Id = 15,
                    Name = "Pulp Fiction",
                    GenreId = 2,
                    DirectorId = 4,
                    Rating = 11.8,
                    Image = "Pulp Fiction--204ed3ec-457b-4726-bbd1-5b81acade5be.jpg",
                    Year = 1994,
                    Length = new TimeSpan(2, 34, 00),
                    Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption."
                },
                new Movie
                {
                    Id = 16,
                    Name = "The Matrix",
                    GenreId = 3,
                    DirectorId = 8,
                    Rating = 11.3,
                    Image = "The Matrix--7a3d7838-91e7-4c5c-8e4a-277721761a50.jpg",
                    Year = 1999,
                    Length = new TimeSpan(2, 16, 00),
                    Description = "When a beautiful stranger leads computer hacker Neo to a forbidding underworld, he discovers the shocking truth--the life he knows is the elaborate deception of an evil cyber-intelligence."
                }


            );


        }
    }
}
