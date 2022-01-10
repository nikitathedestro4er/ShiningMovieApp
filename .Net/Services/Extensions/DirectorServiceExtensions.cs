using Domain.Entities;
using Services.QueryStringParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Extensions
{
    public static class DirectorServiceExtensions
    {
        public static IEnumerable<Director> Search(this IEnumerable<Director> directors, DirectorParameters parameters)
        {
            if (string.IsNullOrWhiteSpace(parameters.Search))
            {
                return directors;
            }


            var lowerCaseSearchTerm = parameters.Search.Trim().ToLower();

            return directors.Where(p => p.Name.ToLower().Contains(lowerCaseSearchTerm));
        }



        public static IEnumerable<Director> Sort(this IEnumerable<Director> directors, DirectorParameters parameters)
        {

            if (string.IsNullOrWhiteSpace(parameters.Order))
                return directors.OrderBy(e => e.Name);

            switch (parameters.Order)
            {
                case "name desc":
                    return directors.OrderByDescending(m => m.Name).ToList();
                case "id":
                    return directors.OrderBy(m => m.Id).ToList();
                case "id desc":
                    return directors.OrderByDescending(m => m.Id).ToList();
                case "movies":
                    return directors.OrderBy(m => m.Movies.Count).ToList();
                case "movies desc":
                    return directors.OrderByDescending(m => m.Movies.Count).ToList();
                case "birthday":
                    return directors.OrderBy(m => m.Birthday).ToList();
                case "birthday desc":
                    return directors.OrderByDescending(m => m.Birthday).ToList();
                case "rating":
                    return directors.OrderBy(m => m.Rating).ToList();
                case "rating desc":
                    return directors.OrderByDescending(m => m.Rating).ToList();
                case "updated":
                    return directors.OrderBy(m => m.ModifiedDate).ToList();
                case "updated desc":
                    return directors.OrderByDescending(m => m.ModifiedDate).ToList();
                default:
                    return directors.OrderBy(m => m.Name).ToList();
            }

        }
    }
}
