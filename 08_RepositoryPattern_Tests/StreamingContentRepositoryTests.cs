using _08_RepositoryPattern_Repoistory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentRepositoryTests
    {
        [TestMethod]//Create
        public void AddToDirectory_ShouldGetCoorectBoolean()
        {
            //The AAA setup!

            //Arrage
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repository = new StreamingContentRepository();
           
            //Act
            bool addResult = repository.AddContentToDirectory(content);

            //Assert
            Assert.IsTrue(addResult);
        }
        [TestMethod]//Read GetAll
        public void GetDirectory_ShouldReturnCorrectCollection()
        {
            //Arrange
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repo = new StreamingContentRepository();

            //added item to the database....
            repo.AddContentToDirectory(content);

            //Act
            List<StreamingContent> contents = repo.GetAllContents();

            bool directoryHasContent = contents.Contains(content);

            //Assert
            Assert.IsTrue(directoryHasContent);
        }

        private StreamingContentRepository _repo;
        private StreamingContent _content;
        private StreamingContent _content2;
        private StreamingContent _content3;
        private StreamingContent _content4;
        [TestInitialize]
        public void Arrange()
        {
            _repo = new StreamingContentRepository();
            _content = new StreamingContent
                ("Rubber", 
                "A car that comes to life with the power to explode and kill people",
                2, 
                MaturityRating.R,
                GenereType.Horror);

            _content2 = new StreamingContent
               ("Bad Boys",
               "A Cop movie",
               10,
               MaturityRating.R,
               GenereType.Action);

            _content3 = new StreamingContent
               ("Last Action Hero",
               "Another action movie",
               10,
               MaturityRating.R,
               GenereType.Action);

            _content4 = new StreamingContent
               ("50 First Dates",
               "Romance flick, Sandler's awesome!",
               10,
               MaturityRating.R,
               GenereType.RomCom);

            _repo.AddContentToDirectory(_content);
            _repo.AddContentToDirectory(_content2);
            _repo.AddContentToDirectory(_content3);
            _repo.AddContentToDirectory(_content4);
        }

        [TestMethod]
        public void GetByTitle_ShouldReturnCorrectContent()
        {
            //Arrange is done...

            //Act 
            StreamingContent searchResult = _repo.GetContentByTitle("Rubber");

            //Assert
            Assert.AreEqual(_content, searchResult);
        }

        [TestMethod]
        public void UpdateExistingContent_ShouldReturnTrue()
        {
            StreamingContent content = new StreamingContent("Rubber UPDATED", 
                "A car that comes to life, explodes, and kills people",
                3.5,
                MaturityRating.R,
                GenereType.Horror);

            bool updateResult = _repo.UpdateExistingContent("Rubber", content);

            Assert.IsTrue(updateResult);

            StreamingContent modifiedContent=_repo.GetContentByTitle("Rubber UPDATED");
            Console.WriteLine(modifiedContent.Description);
        }
        [TestMethod]
        public void DeleteExistingContent_ShouldReturnTrue()
        {
            //Arrange 
            StreamingContent content = _repo.GetContentByTitle("Rubber");

            //Act
            bool removeResult = _repo.DeleteExistingContent(content);

            //Assert
            Assert.IsTrue(removeResult);
        }
        [TestMethod]
        public void GetAllContentsByGenere()
        {
            //Act 
            List<StreamingContent> contents = _repo.GetAllContentsByGenere(GenereType.Action);

           
        }
    }
}
