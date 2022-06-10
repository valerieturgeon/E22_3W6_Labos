using System.Collections.Generic;
using System.Linq;

namespace MovieLand_Models.ViewModels
{
    public class GenreDetailsVM
    {
        public GenreDetailsVM()
        {
            Movies = new List<MovieForListVM>();
        }
        public GenreDetailsVM(Genre g)
        {
            Id = g.GenreId;
            Name = g.Name;
            Movies = g.Movies.OrderByDescending(mg => mg.Movie.ReleaseYear).ThenBy(mg => mg.Movie.Title).Select(mg => new MovieForListVM(mg.Movie)).ToList();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<MovieForListVM> Movies { get; set; }
}
}
