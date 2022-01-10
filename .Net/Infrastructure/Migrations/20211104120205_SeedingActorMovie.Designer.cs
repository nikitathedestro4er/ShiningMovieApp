﻿// <auto-generated />
using Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20211104120205_SeedingActorMovie")]
    partial class SeedingActorMovie
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ActorMovie", b =>
                {
                    b.Property<int>("ActorsId")
                        .HasColumnType("int");

                    b.Property<int>("MoviesId")
                        .HasColumnType("int");

                    b.HasKey("ActorsId", "MoviesId");

                    b.HasIndex("MoviesId");

                    b.ToTable("ActorMovie");

                    b.HasData(
                        new
                        {
                            ActorsId = 1,
                            MoviesId = 1
                        },
                        new
                        {
                            ActorsId = 2,
                            MoviesId = 1
                        },
                        new
                        {
                            ActorsId = 3,
                            MoviesId = 2
                        },
                        new
                        {
                            ActorsId = 4,
                            MoviesId = 2
                        },
                        new
                        {
                            ActorsId = 5,
                            MoviesId = 3
                        },
                        new
                        {
                            ActorsId = 6,
                            MoviesId = 3
                        },
                        new
                        {
                            ActorsId = 10,
                            MoviesId = 3
                        },
                        new
                        {
                            ActorsId = 11,
                            MoviesId = 3
                        },
                        new
                        {
                            ActorsId = 31,
                            MoviesId = 3
                        },
                        new
                        {
                            ActorsId = 7,
                            MoviesId = 4
                        },
                        new
                        {
                            ActorsId = 8,
                            MoviesId = 4
                        },
                        new
                        {
                            ActorsId = 9,
                            MoviesId = 4
                        },
                        new
                        {
                            ActorsId = 10,
                            MoviesId = 4
                        },
                        new
                        {
                            ActorsId = 11,
                            MoviesId = 4
                        },
                        new
                        {
                            ActorsId = 12,
                            MoviesId = 4
                        },
                        new
                        {
                            ActorsId = 13,
                            MoviesId = 5
                        },
                        new
                        {
                            ActorsId = 14,
                            MoviesId = 5
                        },
                        new
                        {
                            ActorsId = 15,
                            MoviesId = 5
                        },
                        new
                        {
                            ActorsId = 16,
                            MoviesId = 6
                        },
                        new
                        {
                            ActorsId = 17,
                            MoviesId = 6
                        },
                        new
                        {
                            ActorsId = 18,
                            MoviesId = 6
                        },
                        new
                        {
                            ActorsId = 7,
                            MoviesId = 7
                        },
                        new
                        {
                            ActorsId = 19,
                            MoviesId = 7
                        },
                        new
                        {
                            ActorsId = 20,
                            MoviesId = 7
                        },
                        new
                        {
                            ActorsId = 21,
                            MoviesId = 7
                        },
                        new
                        {
                            ActorsId = 21,
                            MoviesId = 8
                        },
                        new
                        {
                            ActorsId = 22,
                            MoviesId = 8
                        },
                        new
                        {
                            ActorsId = 23,
                            MoviesId = 8
                        },
                        new
                        {
                            ActorsId = 24,
                            MoviesId = 8
                        },
                        new
                        {
                            ActorsId = 12,
                            MoviesId = 9
                        },
                        new
                        {
                            ActorsId = 25,
                            MoviesId = 9
                        },
                        new
                        {
                            ActorsId = 26,
                            MoviesId = 9
                        },
                        new
                        {
                            ActorsId = 27,
                            MoviesId = 10
                        },
                        new
                        {
                            ActorsId = 28,
                            MoviesId = 10
                        },
                        new
                        {
                            ActorsId = 29,
                            MoviesId = 10
                        },
                        new
                        {
                            ActorsId = 30,
                            MoviesId = 11
                        },
                        new
                        {
                            ActorsId = 32,
                            MoviesId = 11
                        },
                        new
                        {
                            ActorsId = 31,
                            MoviesId = 11
                        },
                        new
                        {
                            ActorsId = 5,
                            MoviesId = 12
                        },
                        new
                        {
                            ActorsId = 33,
                            MoviesId = 12
                        },
                        new
                        {
                            ActorsId = 34,
                            MoviesId = 12
                        },
                        new
                        {
                            ActorsId = 10,
                            MoviesId = 12
                        },
                        new
                        {
                            ActorsId = 35,
                            MoviesId = 13
                        },
                        new
                        {
                            ActorsId = 7,
                            MoviesId = 13
                        },
                        new
                        {
                            ActorsId = 36,
                            MoviesId = 14
                        },
                        new
                        {
                            ActorsId = 37,
                            MoviesId = 14
                        },
                        new
                        {
                            ActorsId = 38,
                            MoviesId = 15
                        },
                        new
                        {
                            ActorsId = 39,
                            MoviesId = 15
                        },
                        new
                        {
                            ActorsId = 40,
                            MoviesId = 15
                        },
                        new
                        {
                            ActorsId = 21,
                            MoviesId = 15
                        },
                        new
                        {
                            ActorsId = 23,
                            MoviesId = 15
                        },
                        new
                        {
                            ActorsId = 41,
                            MoviesId = 16
                        },
                        new
                        {
                            ActorsId = 42,
                            MoviesId = 16
                        },
                        new
                        {
                            ActorsId = 43,
                            MoviesId = 16
                        },
                        new
                        {
                            ActorsId = 44,
                            MoviesId = 16
                        });
                });

            modelBuilder.Entity("Domain.Entities.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Actor");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Jack Nicholson"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Shelley Duvall"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Keir Dullea"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Gary Lockwood"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Christian Bale"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Heath Ledger"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Leonardo DiCaprio"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Joseph Gordon-Levitt"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Tom Hardy"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Michael Caine"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Cillian Murphy"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Marion Cotillard"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Jason Flemyng"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Jason Statham"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Vinnie Jones"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Robert Downey Jr."
                        },
                        new
                        {
                            Id = 17,
                            Name = "Jude Law"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Mark Strong"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Jamie Foxx"
                        },
                        new
                        {
                            Id = 20,
                            Name = "Christoph Waltz"
                        },
                        new
                        {
                            Id = 21,
                            Name = "Samuel L. Jackson"
                        },
                        new
                        {
                            Id = 22,
                            Name = "Kurt Russell"
                        },
                        new
                        {
                            Id = 23,
                            Name = "Tim Roth"
                        },
                        new
                        {
                            Id = 24,
                            Name = "Michael Madsen"
                        },
                        new
                        {
                            Id = 25,
                            Name = "Samy Naceri"
                        },
                        new
                        {
                            Id = 26,
                            Name = "Frédéric Diefenthal"
                        },
                        new
                        {
                            Id = 27,
                            Name = "Robert De Niro"
                        },
                        new
                        {
                            Id = 28,
                            Name = "Michelle Pfeiffer"
                        },
                        new
                        {
                            Id = 29,
                            Name = "Tommy Lee Jones"
                        },
                        new
                        {
                            Id = 30,
                            Name = "Jean Reno"
                        },
                        new
                        {
                            Id = 31,
                            Name = "Gary Oldman"
                        },
                        new
                        {
                            Id = 32,
                            Name = "Natalie Portman"
                        },
                        new
                        {
                            Id = 33,
                            Name = "Hugh Jackman"
                        },
                        new
                        {
                            Id = 34,
                            Name = "Scarlett Johansson"
                        },
                        new
                        {
                            Id = 35,
                            Name = "Mark Ruffalo"
                        },
                        new
                        {
                            Id = 36,
                            Name = "Bill Skarsgård"
                        },
                        new
                        {
                            Id = 37,
                            Name = "Sophia Lillis"
                        },
                        new
                        {
                            Id = 38,
                            Name = "John Travolta"
                        },
                        new
                        {
                            Id = 39,
                            Name = "Uma Thurman"
                        },
                        new
                        {
                            Id = 40,
                            Name = "Bruce Willis"
                        },
                        new
                        {
                            Id = 41,
                            Name = "Keanu Reeves"
                        },
                        new
                        {
                            Id = 42,
                            Name = "Laurence Fishburne"
                        },
                        new
                        {
                            Id = 43,
                            Name = "Carrie-Anne Moss"
                        },
                        new
                        {
                            Id = 44,
                            Name = "Hugo Weaving"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Director", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Director");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Stanley Kubrick"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Christopher Nolan"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Guy Ritchie"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Quentin Tarantino"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Luc Besson"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Martin Scorsese"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Andy Muschietti"
                        },
                        new
                        {
                            Id = 8,
                            Name = "The Wachowskis"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Genre");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Thriller"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Fantasy"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Detective"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Comedy"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Western"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DirectorId")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<string>("Slug")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DirectorId");

                    b.HasIndex("GenreId");

                    b.ToTable("Movie");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DirectorId = 1,
                            GenreId = 1,
                            Image = "https://upload.wikimedia.org/wikipedia/en/1/1d/The_Shining_%281980%29_U.K._release_poster_-_The_tide_of_terror_that_swept_America_IS_HERE.jpg",
                            Name = "Shining",
                            Rating = 10.9,
                            Slug = "shinig--1980",
                            Year = 1980
                        },
                        new
                        {
                            Id = 2,
                            DirectorId = 1,
                            GenreId = 3,
                            Image = "https://upload.wikimedia.org/wikipedia/en/1/11/2001_A_Space_Odyssey_%281968%29.png",
                            Name = "2001: A Space Odyssey",
                            Rating = 10.199999999999999,
                            Slug = "2001-a-space-odyssey--1968",
                            Year = 1968
                        },
                        new
                        {
                            Id = 3,
                            DirectorId = 2,
                            GenreId = 2,
                            Image = "https://upload.wikimedia.org/wikipedia/en/8/8a/Dark_Knight.jpg",
                            Name = "The Dark Knight",
                            Rating = 9.8000000000000007,
                            Slug = "the-dark-knight--2008",
                            Year = 2008
                        },
                        new
                        {
                            Id = 4,
                            DirectorId = 2,
                            GenreId = 3,
                            Image = "https://upload.wikimedia.org/wikipedia/en/2/2e/Inception_%282010%29_theatrical_poster.jpg",
                            Name = "Inception",
                            Rating = 11.1,
                            Slug = "inception--2010",
                            Year = 2010
                        },
                        new
                        {
                            Id = 5,
                            DirectorId = 3,
                            GenreId = 2,
                            Image = "https://images.wolfgangsvault.com/m/xlarge/ZZZ061560-PO/lock-stock-and-two-smoking-barrels-poster-mar-5-1999.webp",
                            Name = "Lock, Stock and Two Smoking Barrels",
                            Rating = 11.0,
                            Slug = "lock-stock-and-two-smoking-barrels--1998",
                            Year = 1998
                        },
                        new
                        {
                            Id = 6,
                            DirectorId = 3,
                            GenreId = 4,
                            Image = "https://m.media-amazon.com/images/M/MV5BMTg0NjEwNjUxM15BMl5BanBnXkFtZTcwMzk0MjQ5Mg@@._V1_.jpg",
                            Name = "Sherlock Holmes",
                            Rating = 9.6999999999999993,
                            Slug = "sherlock-holmes--2009",
                            Year = 2009
                        },
                        new
                        {
                            Id = 7,
                            DirectorId = 4,
                            GenreId = 6,
                            Image = "https://upload.wikimedia.org/wikipedia/en/8/8b/Django_Unchained_Poster.jpg",
                            Name = "Django Unchained",
                            Rating = 11.0,
                            Slug = "django-unchained--2012",
                            Year = 2012
                        },
                        new
                        {
                            Id = 8,
                            DirectorId = 4,
                            GenreId = 6,
                            Image = "https://upload.wikimedia.org/wikipedia/en/d/d4/The_Hateful_Eight.jpg",
                            Name = "The Hatefull Eight",
                            Rating = 10.0,
                            Slug = "the-hatefull-eight--2015",
                            Year = 2015
                        },
                        new
                        {
                            Id = 9,
                            DirectorId = 5,
                            GenreId = 5,
                            Image = "https://upload.wikimedia.org/wikipedia/en/7/7e/TaxiPoster.jpg",
                            Name = "Taxi",
                            Rating = 10.5,
                            Slug = "taxi--1998",
                            Year = 1998
                        },
                        new
                        {
                            Id = 10,
                            DirectorId = 5,
                            GenreId = 5,
                            Image = "https://upload.wikimedia.org/wikipedia/en/7/75/The_Family_2013%2C_Poster.jpg",
                            Name = "Malavita",
                            Rating = 9.6999999999999993,
                            Slug = "malavita--2013",
                            Year = 2013
                        },
                        new
                        {
                            Id = 11,
                            DirectorId = 5,
                            GenreId = 2,
                            Image = "https://upload.wikimedia.org/wikipedia/uk/e/e1/L%C3%A9on_poster.JPG",
                            Name = "Léon: The Professional",
                            Rating = 10.9,
                            Slug = "léon-the-proffesional--1994",
                            Year = 1994
                        },
                        new
                        {
                            Id = 12,
                            DirectorId = 2,
                            GenreId = 4,
                            Image = "https://i.pinimg.com/originals/02/88/8a/02888af9053561a41e4276e33588403b.jpg",
                            Name = "The Prestige",
                            Rating = 10.199999999999999,
                            Slug = "prestige--2006",
                            Year = 2006
                        },
                        new
                        {
                            Id = 13,
                            DirectorId = 6,
                            GenreId = 1,
                            Image = "https://upload.wikimedia.org/wikipedia/en/7/76/Shutterislandposter.jpg",
                            Name = "Shutter Island",
                            Rating = 10.4,
                            Slug = "shutter-island--2010",
                            Year = 2010
                        },
                        new
                        {
                            Id = 14,
                            DirectorId = 7,
                            GenreId = 1,
                            Image = "https://upload.wikimedia.org/wikipedia/en/5/5a/It_%282017%29_poster.jpg",
                            Name = "It",
                            Rating = 10.0,
                            Slug = "it--2017",
                            Year = 2017
                        },
                        new
                        {
                            Id = 15,
                            DirectorId = 4,
                            GenreId = 2,
                            Image = "https://upload.wikimedia.org/wikipedia/en/3/3b/Pulp_Fiction_%281994%29_poster.jpg",
                            Name = "Pulp Fiction",
                            Rating = 11.800000000000001,
                            Slug = "pulp-fiction--1994",
                            Year = 1994
                        },
                        new
                        {
                            Id = 16,
                            DirectorId = 8,
                            GenreId = 3,
                            Image = "https://upload.wikimedia.org/wikipedia/en/thumb/c/c1/The_Matrix_Poster.jpg/220px-The_Matrix_Poster.jpg",
                            Name = "The Matrix",
                            Rating = 11.300000000000001,
                            Slug = "the-matrix--1999",
                            Year = 1999
                        });
                });

            modelBuilder.Entity("ActorMovie", b =>
                {
                    b.HasOne("Domain.Entities.Actor", null)
                        .WithMany()
                        .HasForeignKey("ActorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Movie", b =>
                {
                    b.HasOne("Domain.Entities.Director", "Director")
                        .WithMany("Movies")
                        .HasForeignKey("DirectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Genre", "Genre")
                        .WithMany("Movies")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Director");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("Domain.Entities.Director", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("Domain.Entities.Genre", b =>
                {
                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}