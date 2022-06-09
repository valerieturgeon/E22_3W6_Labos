namespace MovieLand_Models.ViewModels
{
    public class MovieForListVM
    {
        public MovieForListVM()
        {
        }
        public MovieForListVM(Movie m)
        {
            Id = m.MovieId;
            Title = m.Title;
            Poster = m.Poster;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Poster { get; set; }
    }
}
