using System;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcMovie.Models
{
	public class MovieGenreViewModel
	{
        internal List<Movie> Movies;

        public string SearchString { get; set; }
        public string MovieGenre { get; set; }

        public SelectList Genres { get; internal set; }
    }
}

