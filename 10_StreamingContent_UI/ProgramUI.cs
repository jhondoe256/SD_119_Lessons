using _08_RepositoryPattern_Repoistory;
using _09_StreamingContent_Inheritance;
using _09_StreamingContent_Inheritance.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using static System.Console;

namespace _10_StreamingContent_UI
{
    public class ProgramUI
    {
        private readonly StreamingRepository _repo = new StreamingRepository();
        public void Run()
        {
            SeedContent();
            ShowMenu();
        }

        private void ShowMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine(
                    "Enter the option you'd like to select:\n" +
                    "1. Show all streaming content\n" +
                    "2. Find streaming content by title\n" +
                    "3. Add new content\n" +
                    "4. Remove content item\n" +
                    "5. Exit\n");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        ShowAllContent();
                        break;
                    case "2":
                        ShowContentByTitle();
                        break;
                    case "3":
                        CreateNewContent();
                        break;
                    case "4":
                        RemoveContent();
                        break;
                    case "5":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a number between 1 and 5");
                        WaitForKeyPress();
                        break;
                }
            }
        }

        // Menu options refer to methods...
        private void ShowAllContent()
        {
            Console.Clear();
            Console.WriteLine("Streaming content available:");
            List<StreamingContent> contents = _repo.GetAllContents();
            foreach (StreamingContent item in contents)
            {
                DisplayContentListItem(item);
            }

            WaitForKeyPress();
        }

        private void ShowContentByTitle()
        {
            Console.Clear();
            Console.Write("Please enter a title: ");
            string title = Console.ReadLine();
            StreamingContent item = _repo.GetContentByTitle(title);

            if (item == null)
            {
                Console.WriteLine("Item not found :(");
            }
            else
            {
                DisplayContentItemDetails(item);
            }

            WaitForKeyPress();
        }

        private void CreateNewContent()
        {
            Console.Clear();
            StreamingContent content = new StreamingContent();

            bool inputIsValid;
            do
            {
                inputIsValid = true;
                Console.WriteLine("Is this a Movie or a Show?\n" +
                    "1. Movie\n" +
                    "2. Show");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        content = new Movie();
                        break;
                    case "2":
                        content = new Show();
                        break;
                    default:
                        inputIsValid = false;
                        Console.WriteLine("Please enter a valid selection");
                        WaitForKeyPress();
                        break;
                }
            } while (!inputIsValid);

            Console.Write("Please enter a title: ");
            string title = Console.ReadLine();
            content.Title = title;

            Console.Write("Please enter a description: ");
            content.Description = Console.ReadLine();

            Console.Write("Please enter a star rating (1-5): ");
            content.StarRating = double.Parse(Console.ReadLine());

            Console.WriteLine("Select a Genre:\n" +
                "1. Horror\n" +
                "2. Romantic Comedy\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Bromance\n" +
                "6. Drama\n" +
                "7. Action\n");
            string genreString = Console.ReadLine();

            /*
            switch {
                case "1":
                    content.TypeOfGenere = GenereType.Horror;
                    break;
                case "2":
                    ...
            }
            */

            int genreNumber = Convert.ToInt32(genreString);
            content.TypeOfGenere = (GenereType) genreNumber;

            // Ditto for maturity rating...

            if (content is Movie)
            {
                Console.Write("Please enter the runtime (in minutes): ");
                string runTimeString = Console.ReadLine();
                double runTime = Convert.ToDouble(runTimeString);
                ((Movie) content).RunTime = runTime;
            }

            _repo.AddContentToDirectory(content);
        }

        private void RemoveContent()
        {
            Console.Clear();
            Console.WriteLine("Which item would you like to remove?");

            int index = 0;
            List<StreamingContent> contents = _repo.GetAllContents();
            foreach (StreamingContent item in contents)
            {
                Console.Write($"{index + 1}. ");
                DisplayContentListItem(item);
                index++;
            }
            string optionString = Console.ReadLine();
            int option = Convert.ToInt32(optionString);

            StreamingContent itemToDelete = contents[option - 1];

            // OPTIONAL
            Console.WriteLine("Are you sure you want to delete this? (y/n)");
            DisplayContentItemDetails(itemToDelete);
            if (Console.ReadLine() == "y")
            {
                _repo.DeleteExistingContent(itemToDelete);
                Console.WriteLine("Item deleted!");
            } else
            {
                Console.WriteLine("Canceled");
            }
            WaitForKeyPress();
        }

        private void DisplayContentListItem(StreamingContent content)
        {
            Console.WriteLine($"{content.Title} ({content.GetType().Name})\n" +
                $"======================");
        }

        private void DisplayContentItemDetails(StreamingContent content)
        {
            Console.WriteLine($"={content.GetType().Name}=\n" +
                $"Title: {content.Title}\n" +
                $"Description: {content.Description}\n" +
                $"Star Rating: {content.StarRating}\n" +
                $"Genre: {content.TypeOfGenere}\n" +
                $"{(content is Movie ? "Runtime: " + ((Movie) content).RunTime + "\n" : "")}" +
                $"======================");
        }

        private void WaitForKeyPress()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private void SeedContent()
        {
            // Make some movies and shows, add them to the repo
            Movie futureWar = new Movie();
            futureWar.Title = "Future War";
            futureWar.Description = "Jean-Claude Gosh Darn fights dinosaur puppets from the future and Robert Z'Dar in a cardboard cyborg costume.";
            futureWar.TypeOfGenere = GenereType.SciFi;
            futureWar.StarRating = 1;
            _repo.AddContentToDirectory(futureWar);

            Movie freaked = new Movie();
            freaked.Title = "Freaked";
            freaked.StarRating = 5;
            _repo.AddContentToDirectory(freaked);
        }
    }
}
