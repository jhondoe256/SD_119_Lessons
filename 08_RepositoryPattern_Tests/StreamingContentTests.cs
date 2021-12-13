using _08_RepositoryPattern_Repoistory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _08_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentTests
    {
        //Ask ourselves What do we want to test?
        //Should we test all properties?
        //Should we test specific conditions....
        [TestMethod]
        public void SetTitle_ShouldSetCorrectString()
        {
            //1 we need to make a StreamingContent container/variable....
            StreamingContent content = new StreamingContent();

            //assigning the value to content.Title (a property that lives on the content variable/container)
            content.Title = "Toy Story";

            string expected = "Toy Story";
            string actual = content.Title;

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        [DataRow(MaturityRating.G,true)]
        [DataRow(MaturityRating.TV_PG,true)]
        [DataRow(MaturityRating.R,false)]
        [DataRow(MaturityRating.TV_MA,false)]
        public void SetMaturityRating_ShouldGetCorrectIsFamilyFriendly(MaturityRating rating, bool expectedFamilyFriendly)
        {
            StreamingContent content = new StreamingContent("Content title","Some Description",4.2d, rating ,GenereType.SciFi);

            bool actual = content.IsFamilyFriendly;
            bool expected = expectedFamilyFriendly;

            Assert.AreEqual(expected, actual);
        }
    }
}
