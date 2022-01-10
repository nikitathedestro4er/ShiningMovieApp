using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Infrastructure.Configurations
{
    internal sealed class DirectorConfiguration : IEntityTypeConfiguration<Director>
    {
        public void Configure(EntityTypeBuilder<Director> builder)
        {
            builder.ToTable(nameof(Director));

            builder.HasKey(director => director.Id);

            builder.Property(director => director.Id).ValueGeneratedOnAdd();

            builder.Property(director => director.Name).IsRequired().HasMaxLength(50);

            builder.Property(director => director.Image).IsRequired();

            builder.Property(director => director.Birthday).IsRequired().HasColumnType("date");

            builder.Property(director => director.Rating).IsRequired();

            builder.Property(director => director.Description).IsRequired().HasMaxLength(500);

            builder.Property(director => director.CreationTime).IsRequired();

            builder.Property(director => director.ModifiedDate).IsRequired();


            builder.HasMany(director => director.Movies).WithOne().HasForeignKey(movie => movie.DirectorId);

            builder.HasData(
                 new Director
                 {
                     Id = 1,
                     Name = "Stanley Kubrick",
                     Birthday = new DateTime(1928, 07, 26),
                     Rating = 12.3,
                     Image = "Stanley Kubrick--0db9f42e-0a59-4179-a72e-334f5483f5a3.jpg",
                     Description = "Stanley Kubrick was born in Manhattan, New York City, to Sadie Gertrude (Perveler) and Jacob Leonard Kubrick, a physician. His family were Jewish immigrants (from Austria, Romania, and Russia). Stanley was considered intelligent, despite poor grades at school. Hoping that a change of scenery would produce better academic performance, Kubrick's ..."
                 },
                new Director
                {
                    Id = 2,
                    Name = "Christopher Nolan",
                    Birthday = new DateTime(1970, 07, 30),
                    Rating = 12.5,
                    Image = "Christopher Nolan--d28e2806-d48a-4f03-bf09-6be7cf7b7d43.jpg",
                    Description = "Best known for his cerebral, often nonlinear, storytelling, acclaimed writer-director Christopher Nolan was born on July 30, 1970, in London, England. Over the course of 15 years of filmmaking, Nolan has gone from low-budget independent films to working on some of the biggest blockbusters ever made. At 7 years old, Nolan began making short movies ..."
                },
                new Director
                {
                    Id = 3,
                    Name = "Guy Ritchie",
                    Birthday = new DateTime(1968, 09, 10),
                    Rating = 12.3,
                    Image = "Guy Ritchie--0ec7447e-bfe1-4a5d-a413-cd27ca7447d9.jpg",
                    Description = "Guy Ritchie was born in Hatfield, Hertfordshire, UK on September 10, 1968. After watching Butch Cassidy and the Sundance Kid (1969) as a child, Guy realized that what he wanted to do was make films. He never attended film school, saying that the work of film school graduates was boring and unwatchable. At 15 years old, he dropped out of school and..."
                },
                new Director
                {
                    Id = 4,
                    Name = "Quentin Tarantino",
                    Birthday = new DateTime(1963, 03, 27),
                    Rating = 13.0,
                    Image = "Quentin Tarantino--f1408446-a750-4d4a-9a34-d3eab361410a.jpg",
                    Description = "Quentin Jerome Tarantino was born in Knoxville, Tennessee. His father, Tony Tarantino, is an Italian-American actor and musician from New York, and his mother, Connie (McHugh), is a nurse from Tennessee. Quentin moved with his mother to Torrance, California, when he was four years old. In January of 1992, first-time writer-director Tarantino's ..."
                },
                new Director
                {
                    Id = 5,
                    Name = "Luc Besson",
                    Birthday = new DateTime(1959, 03, 18),
                    Rating = 12.6,
                    Image = "Luc Besson-ae52a9f6-7f52-491a-ae0c-10c0f43a00ab.jpg",
                    Description = "Luc Besson spent the first years of his life following his parents, scuba diving instructors, around the world. His early life was entirely aquatic. He already showed amazing creativity as a youth, writing early drafts of The Big Blue (1988) and The Fifth Element (1997), as an adolescent bored in school. He planned on becoming a marine biologist ..."
                },
                new Director
                {
                    Id = 6,
                    Name = "Martin Scorsese",
                    Birthday = new DateTime(1942, 11, 17),
                    Rating = 11.9,
                    Image = "Martin Scorsese--877c1c9a-eb59-4ccd-9638-0a098af349ee.jpg",
                    Description = "Martin Charles Scorsese was born on November 17, 1942 in Queens, New York City, to Catherine Scorsese (née Cappa) and Charles Scorsese, who both worked in Manhattan's garment district, and whose families both came from Palermo, Sicily. He was raised in the neighborhood of Little Italy, which later provided the inspiration for several of his films...."
                },
                new Director
                {
                    Id = 7,
                    Name = "Andy Muschietti",
                    Birthday = new DateTime(1973, 08, 26),
                    Rating = 10.2,
                    Image = "Andy Muschietti--c1b94fad-1a6f-4fec-b86a-cda7c4806877.jpg",
                    Description = "Andy Muschietti was born on August 26, 1973 in Buenos Aires, Federal District, Argentina as Andrés Muschietti. He is a producer and director, known for Mama (2013), It (2017) and It: Chapter Two (2019)."
                },
                new Director
                {
                    Id = 8,
                    Name = "Lilly Wachowski",
                    Birthday = new DateTime(1967, 12, 29),
                    Rating = 12.3,
                    Image = "Lilly Wachowski--c5d08ab1-730d-40f2-a332-d6a226684a50.jpg",
                    Description = "Director, writer, and producer Lilly Wachowski was born in 1967 in Chicago, the daughter of Lynne, a nurse and painter, and Ron, a businessman. Lilly was educated at Kellogg Elementary School in Chicago, before moving on to Whitney M. Young High School. After graduating from high school, she attended Emerson College in Boston but dropped out. Lilly..."
                }
            );
        }
    }
}
