using _08_RepositoryPattern_Repoistory;
using _09_StreamingContent_Inheritance.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StreamingContent_Inheritance
{
    public class StreamingRepository : StreamingContentRepository
    {
        public Show GetShowByTitle(string title)
        {
            foreach(StreamingContent content in _contentDirectory)
            {
                if (content is Show && content.Title == title)
                {
                    return (Show) content;
                }
            }
            return null;
        }

        public List<Show> GetAllShows()
        {
            // V1
            List<Show> allShows = new List<Show>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.GetType() == typeof(Show)) // if (content is Show)
                {
                    allShows.Add((Show) content);
                }
            }
            return allShows;


            // V2
            return _contentDirectory
                .Where(c => c is Show)
                .Select(c => (Show) c)
                .ToList();
        }

        // CHALLENGE:

        // GetMoviesByRating()
        public List<Movie> GetMoviesByRating(MaturityRating rating)
        {
            // V1
            return (List<Movie>) _contentDirectory
                .Where(c => c.MaturityRating == rating && c is Movie)
                .Select(c => (Movie) c);


            // V2
            List<Movie> movies = new List<Movie>();
            foreach(StreamingContent content in _contentDirectory)
            {
                if (content.MaturityRating == rating && content is Movie)
                {
                    movies.Add((Movie) content);
                }
            }
            return movies;
        }

        // GetFamilyFriendlyShows()
        public List<Show> GetFamilyFriendlyShows()
        {
            // NO: double cast doesn't work like this
            // return (List<Show>) _contentDirectory.Where(sc => sc is Show && sc.IsFamilyFriendly);

           // return GetAllShows().Where(s => s.IsFamilyFriendly).ToList();
        }
    }
}
