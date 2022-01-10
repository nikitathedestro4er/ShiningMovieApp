using Domain.Entities;
using Services.QueryStringParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Extensions
{
    public static class MovieServiceExtensions
    {
        public static IEnumerable<Movie> Filter(this IEnumerable<Movie> movies, MovieParameters parameters)
        {

            if (parameters.GenreId != null)
            {
                movies = movies.Where(m => m.GenreId == parameters.GenreId);
            }


            if (parameters.MinYear != null)
            {
                movies = movies.Where(m => m.Year <= parameters.MaxYear && m.Year >= parameters.MinYear);
            }
            else
            {
                movies = movies.Where(m => m.Year <= parameters.MaxYear);
            }


            if (parameters.DirectorId != null)
            {
                return movies.Where(m => m.DirectorId == parameters.DirectorId);
            }

            return movies;
        }
        



        public static IEnumerable<Movie> Search(this IEnumerable<Movie> movies, MovieParameters parameters)
        {
            if (string.IsNullOrWhiteSpace(parameters.Search))
            {
                return movies;
            }
                

            var lowerCaseSearchTerm = parameters.Search.Trim().ToLower();

            return movies.Where(p => p.Name.ToLower().Contains(lowerCaseSearchTerm));
        }



        public static IEnumerable<Movie> Sort(this IEnumerable<Movie> movies, MovieParameters parameters)
        {

            if (string.IsNullOrWhiteSpace(parameters.Order))
                return movies.OrderBy(e => e.Name);

            switch (parameters.Order)
            {
                case "name desc":
                    return movies.OrderByDescending(m => m.Name).ToList();                
                case "id":
                    return movies.OrderBy(m => m.Id).ToList();
                    case "id desc":
                    return movies.OrderByDescending(m => m.Id).ToList();
                case "genre":
                    return movies.OrderBy(m => m.Genre.Name).ToList();
                case "genre desc":
                    return movies.OrderByDescending(m => m.Genre.Name).ToList();
                case "director":
                    return movies.OrderBy(m => m.Director.Name).ToList();
                case "director desc":
                    return movies.OrderByDescending(m => m.Director.Name).ToList();
                case "year":
                    return movies.OrderBy(m => m.Year).ToList();
                case "year desc":
                    return movies.OrderByDescending(m => m.Year).ToList();
                case "rating":
                    return movies.OrderBy(m => m.Rating).ToList();
                case "rating desc":
                    return movies.OrderByDescending(m => m.Rating).ToList();
                case "updated":
                    return movies.OrderBy(m => m.ModifiedDate).ToList();
                case "updated desc":
                    return movies.OrderByDescending(m => m.ModifiedDate).ToList();
                default:
                    return movies.OrderBy(m => m.Name).ToList();
            }

           




        }


    }

}
