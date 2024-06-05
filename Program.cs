using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Prog120_S24_FinalReview1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Laugh Out Loud Moments
            // Comedy
            // 2592
            // 0 hours, 43 mins, 12 seconds
            // 567794

            Video tempVideo = new Video("Laugh Out Loud Moments", 0, 2592, 567794);

            string tempVideoDisplayString = tempVideo.DisplayWithFormatting();

            Console.WriteLine(tempVideoDisplayString);

        } // Main


        public static void TimeFormattingExample()
        {
            int numOfSeconds = 17779;
            int secondsInMinutes = 60;
            int minutesInHours = 60;

            // This equation will get the TOTAL minutes
            int totalMinutes = numOfSeconds / secondsInMinutes;

            int hours = totalMinutes / minutesInHours;

            int minutes = totalMinutes % minutesInHours;

            // This equation will always return the remaining seconds
            int seconds = numOfSeconds % secondsInMinutes;
            //numOfSeconds %= secondsInMinutes;

            string formattedTime = $"{hours}:{minutes}:{seconds}";

            //Console.WriteLine(hours);
            //Console.WriteLine(minutes);
            //Console.WriteLine(seconds);
            Console.WriteLine(formattedTime);
        }

    } // class Program



    // ---- In My Namespace, but underneath program create our new class, Video

    public class Video
    {
        // Fields
        public string Name;
        public int Category;
        public int Duration;
        public int Views;

        // Constructors
        public Video(string name, int category, int duration, int views)
        {
            Name = name;
            Category = category;
            Duration = duration;
            Views = views;
        }

        // Default Constructor
        public Video()
        {
            Name = "No Video";
            Category = -1;
            Duration = 0;
            Views = 0;
        }


        // Methods

        public string DisplayFormattedTime()
        {

            int numOfSeconds = Duration;
            int secondsInMinutes = 60;
            int minutesInHours = 60;

            // This equation will get the TOTAL minutes
            int totalMinutes = numOfSeconds / secondsInMinutes;

            // Get total hours
            int hours = totalMinutes / minutesInHours;

            // Get Total Minutes
            int minutes = totalMinutes % minutesInHours;

            // This equation will always return the remaining seconds
            int seconds = numOfSeconds % secondsInMinutes;
            //numOfSeconds %= secondsInMinutes;

            string formattedTime = $"{hours}:{minutes}:{seconds}";

            return formattedTime;
        }

        public string DisplayCategory()
        {
            //        Categories
            //- Comedy : 0
            //- Action : 1
            //- Vlog : 2
            //- Animation : 3
            string categoryName = "";

            switch(Category)
            {
                case 0:
                    categoryName = "Comedy";
                    break;
                case 1:
                    categoryName = "Action";
                    break;
                case 2:
                    categoryName = "Vlog";
                    break;
                case 3:
                    categoryName = "Animation";
                    break;
                default:
                    categoryName = "No Category";
                    break;

            }

            return categoryName;
        }

        public string DisplayWithFormatting()
        {
            //Display With Formatting ( Do i create a method in program, or can I create a method in the Data class to do this )

            //- Video Name
            //- Category ( Name, not number )
            //- Duration ( In Formatted Time )
            //- Number of View

            string formattedString = "";
            formattedString += Name + "\n"; // Name
            formattedString += DisplayCategory() + "\n"; // Category
            formattedString += DisplayFormattedTime() + "\n"; // Formatted Time
            formattedString += $"Views: {Views} \n"; // Views : Views

            return formattedString;
        }

    }

} // namespace

//Create a class from data provided


//Display All Videos ( Probably need a loop )



//Add Videos ( Collection expands if we run out of room ) ( Lecture 13 - Array Capacity  )

//Edit Videos (Refresher)

//Return all videos by category ( Using Linear Search - Returning a new array )

//Find and Display Video by Name ( Using Linear Search )

//Get Average Length of Videos ( Loop and Operations )

//Get All Videos Above a certain view count ( Linear Search )

//Create Menu for everything ( Create a menu using a switch and while loop )

