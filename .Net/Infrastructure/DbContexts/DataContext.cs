using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Infrastructure.DbContexts
{
    public sealed class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }


        public DbSet<Movie> Movies { get; set; }
        
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Director> Directors { get; set; }
        
        public DbSet<Actor> Actors { get; set; }

        public DbSet<Comment> Comments { get; set; }
        
        public DbSet<Rating> Ratings { get; set; }

        public DbSet<ReplyComment> Replies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);


            modelBuilder.SharedTypeEntity<Dictionary<string, object>>("ActorMovie")
                .HasData(
                    new { MoviesId = 1, ActorsId = 1 },
                    new { MoviesId = 1, ActorsId = 2 },


                    new { MoviesId = 2, ActorsId = 3 },
                    new { MoviesId = 2, ActorsId = 4 },


                    new { MoviesId = 3, ActorsId = 5 },
                    new { MoviesId = 3, ActorsId = 6 },
                    new { MoviesId = 3, ActorsId = 10 },
                    new { MoviesId = 3, ActorsId = 11 },
                    new { MoviesId = 3, ActorsId = 31 },


                    new { MoviesId = 4, ActorsId = 7 },
                    new { MoviesId = 4, ActorsId = 8 },
                    new { MoviesId = 4, ActorsId = 9 },
                    new { MoviesId = 4, ActorsId = 10 },
                    new { MoviesId = 4, ActorsId = 11 },
                    new { MoviesId = 4, ActorsId = 12 },


                    new { MoviesId = 5, ActorsId = 13 },
                    new { MoviesId = 5, ActorsId = 14 },
                    new { MoviesId = 5, ActorsId = 15 },


                    new { MoviesId = 6, ActorsId = 16 },
                    new { MoviesId = 6, ActorsId = 17 },
                    new { MoviesId = 6, ActorsId = 18 },


                    new { MoviesId = 7, ActorsId = 7 },
                    new { MoviesId = 7, ActorsId = 19 },
                    new { MoviesId = 7, ActorsId = 20 },
                    new { MoviesId = 7, ActorsId = 21 },


                    new { MoviesId = 8, ActorsId = 21 },
                    new { MoviesId = 8, ActorsId = 22 },
                    new { MoviesId = 8, ActorsId = 23 },
                    new { MoviesId = 8, ActorsId = 24 },


                    new { MoviesId = 9, ActorsId = 12 },
                    new { MoviesId = 9, ActorsId = 25 },
                    new { MoviesId = 9, ActorsId = 26 },


                    new { MoviesId = 10, ActorsId = 27 },
                    new { MoviesId = 10, ActorsId = 28 },
                    new { MoviesId = 10, ActorsId = 29 },


                    new { MoviesId = 11, ActorsId = 30 },
                    new { MoviesId = 11, ActorsId = 32 },
                    new { MoviesId = 11, ActorsId = 31 },


                    new { MoviesId = 12, ActorsId = 5 },
                    new { MoviesId = 12, ActorsId = 33 },
                    new { MoviesId = 12, ActorsId = 34 },
                    new { MoviesId = 12, ActorsId = 10 },


                    new { MoviesId = 13, ActorsId = 35 },
                    new { MoviesId = 13, ActorsId = 7 },


                    new { MoviesId = 14, ActorsId = 36 },
                    new { MoviesId = 14, ActorsId = 37 },


                    new { MoviesId = 15, ActorsId = 38 },
                    new { MoviesId = 15, ActorsId = 39 },
                    new { MoviesId = 15, ActorsId = 40 },
                    new { MoviesId = 15, ActorsId = 21 },
                    new { MoviesId = 15, ActorsId = 23 },


                    new { MoviesId = 16, ActorsId = 41 },
                    new { MoviesId = 16, ActorsId = 42 },
                    new { MoviesId = 16, ActorsId = 43 },
                    new { MoviesId = 16, ActorsId = 44 }


                );
        }
            
    }
}
