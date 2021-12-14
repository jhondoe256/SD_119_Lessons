using _08_RepositoryPattern_Repoistory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StreamingContent_Inheritance.Content
{
    public class Show : StreamingContent
    {
        public List<Episode> Episodes { get; set; } = new List<Episode>();

        
        // Refactor these to use the actual Episode list ^^
        public int SeasonCount
        {
            get
            {
                int highestSeasonNumber = 0;
                foreach (Episode ep in Episodes)
                {
                    if (ep.SeasonNumber > highestSeasonNumber)
                    {
                        highestSeasonNumber = ep.SeasonNumber;
                    }
                }
                return highestSeasonNumber;

                return Episodes.Select(episode => episode.SeasonNumber).Max();
            }
        }
        public int EpisodeCount { get { return Episodes.Count; } }
        public double AverageRunTime {
            get
            {
                double totalTime = 0;
                foreach(Episode ep in Episodes)
                {
                    totalTime += ep.RunTime;
                }
                return totalTime / (double) EpisodeCount;

                return Episodes.Select(e => e.RunTime).Average();
            }
        }
    }

    public class Episode
    {
        public string Title { get; set; }
        public double RunTime { get; set; }
        public int SeasonNumber { get; set; }
    }
}
