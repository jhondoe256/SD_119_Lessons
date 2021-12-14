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

        // GetFamilyFriendlyShows()
    }
}
