using Domain.Entities;
using Services.QueryStringParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Extensions
{
    public static class ActorServiceExtensions
    {
        public static IEnumerable<Actor> Search(this IEnumerable<Actor> actors, ActorParameters parameters)
        {
            if (string.IsNullOrWhiteSpace(parameters.Search))
            {
                return actors;
            }


            var lowerCaseSearchTerm = parameters.Search.Trim().ToLower();

            return actors.Where(p => p.Name.ToLower().Contains(lowerCaseSearchTerm));
        }

        public static IEnumerable<Actor> Sort(this IEnumerable<Actor> actors, ActorParameters parameters)
        {

            if (string.IsNullOrWhiteSpace(parameters.Order))
                return actors.OrderBy(e => e.Name);

            switch (parameters.Order)
            {
                case "name desc":
                    return actors.OrderByDescending(m => m.Name).ToList();
                case "id":
                    return actors.OrderBy(m => m.Id).ToList();
                case "id desc":
                    return actors.OrderByDescending(m => m.Id).ToList();
                case "movies":
                    return actors.OrderBy(m => m.Movies.Count).ToList();
                case "movies desc":
                    return actors.OrderByDescending(m => m.Movies.Count).ToList();
                case "birthday":
                    return actors.OrderBy(m => m.Birthday).ToList();
                case "birthday desc":
                    return actors.OrderByDescending(m => m.Birthday).ToList();
                case "rating":
                    return actors.OrderBy(m => m.Rating).ToList();
                case "rating desc":
                    return actors.OrderByDescending(m => m.Rating).ToList();
                case "updated":
                    return actors.OrderBy(m => m.ModifiedDate).ToList();
                case "updated desc":
                    return actors.OrderByDescending(m => m.ModifiedDate).ToList();
                default:
                    return actors.OrderBy(m => m.Name).ToList();
            }

        }
    }
}
