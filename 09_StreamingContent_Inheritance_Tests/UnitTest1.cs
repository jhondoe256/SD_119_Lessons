using _08_RepositoryPattern_Repoistory;
using _09_StreamingContent_Inheritance;
using _09_StreamingContent_Inheritance.Content;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _09_StreamingContent_Inheritance_Tests
{
    [TestClass]
    public class UnitTest1
    {
        private StreamingRepository _repo;
        string testTitle1 = "Arrested Development";

        [TestInitialize]
        public void ArrangeRepo()
        {
            _repo = new StreamingRepository();

            Show show = new Show();
            show.Title = testTitle1;

            Episode ep1 = new Episode() {
                Title = "Not Without My Daughter",
                SeasonNumber = 1,
                RunTime = 22
            };

            Episode ep2 = new Episode()
            {
                Title = "Queen for a Day",
                SeasonNumber = 2,
                RunTime = 23
            };

            show.Episodes = new List<Episode> { ep1, ep2 };
            show.MaturityRating = MaturityRating.TV_14;

            _repo.AddContentToDirectory(show);
        }

        [TestMethod]
        public void FamilyFriendlyShowTest()
        {
            // Arrange
            // Act
            List<Show> shows = _repo.GetFamilyFriendlyShows();
            // Assert
            int expected = 0;
            int actual = shows.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AverageRunTimeTest()
        {
            // Arrange
            // Act
            Show ad = _repo.GetShowByTitle(testTitle1);
            // Assert
            double expected = 22.5;
            double actual = ad.AverageRunTime;

            Assert.AreEqual(expected, actual);
        }
    }
}
