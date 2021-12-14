using _08_RepositoryPattern_Repoistory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StreamingContent_Inheritance.Content
{
    public class Movie : StreamingContent
    {
        public Movie() { }

        public Movie(
            string title,
            string description,
            MaturityRating rating,
            GenereType genre,
            double stars,
            double runTime
            ) : base(title, description, stars, rating, genre)
        {
            RunTime = runTime;
        }

        public double RunTime { get; set; }

        // other properties like Director, ReleaseDate, BoxOffice...
    }
}
