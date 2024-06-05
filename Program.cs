using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Prog120_S24_FinalReview1
{
    internal class Program
    {
        // Collections of Videos

        static Video[] videos = new Video[2];

        static void Main(string[] args)
        {
            Preload();
            AddVideo();
  
        } // Main

        public static void Preload()
        {
            videos[0] = new Video("Laugh Out Loud Moments", 0, 2592, 567794);
            videos[1] = new Video("My Morning Routine Vlog", 2, 4541, 70378);
        }

        //Create a class from data provided

        //Display All Videos ( Probably need a loop )
        public static void DisplayAllVideos()
        {

            // foreach ( TYPE varName in collection ) {}
            foreach(Video vid in videos)
            {
                if(vid != null)
                {
                    Console.WriteLine(vid.DisplayWithFormatting());
                }
                
            }

        }

        //Add Videos ( Collection expands if we run out of room ) ( Lecture 13 - Array Capacity  )
        public static void AddVideo()
        {
            // Name
            // Category
            // Duration
            // Views
            try
            {
                // Prompt User for Video Information
                Video usersVideo = GenerateUsersVideo();

                int openIndex = LastAvailableIndex();

                if(openIndex == -1)
                {
                    Console.WriteLine("The array is full");
                    IncraseArraySize();
                    openIndex = LastAvailableIndex();
                }

                videos[openIndex] = usersVideo;
                DisplayAllVideos();

                //

            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter a valid number.");
            } 

        }

        // Double the array size and move the elements from the first array to the second
        public static void IncraseArraySize()
        {
            // Make a temp array double the size of the first array
            Video[] tempArray = new Video[videos.Length * 2];

            // Move the elements from the first array to the second
            for (int i = 0; i < videos.Length; i++)
            {
                tempArray[i] = videos[i];
            }

            // Replace the original array with the new one
            videos = tempArray;
        }


        // Checks for last open element
        public static int LastAvailableIndex()
        {
            // Go through each element in the array

            for (int i = 0; i < videos.Length; i++)
            {
                // checking to see if a spot in the array is null
                Video temp = videos[i];

                if(temp == null)
                {
                    // returning the index of the empty space
                    return i;
                }

            }

            // If no empty space is found, return -1
            return -1;
        }

        public static Video GenerateUsersVideo()
        {
            Console.Write("Enter a video name: ");
            string videoName = Console.ReadLine();
            Console.Write("Enter a Category name - 1 Comedy  - 2 Action - 3 Vlog - 4 Animation: ");
            int category = int.Parse(Console.ReadLine());
            Console.Write("Enter duration in seconds ");
            int duration = int.Parse(Console.ReadLine());
            Console.Write("Enter number of Views ");
            int views = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Video newVideo = new Video(videoName, category, duration, views);
            return newVideo;
        }


        //Edit Videos (Refresher)

        //Create Menu for everything ( Create a menu using a switch and while loop )


        #region Examples

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

        #endregion Examples

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



//Return all videos by category ( Using Linear Search - Returning a new array )

//Find and Display Video by Name ( Using Linear Search )

//Get Average Length of Videos ( Loop and Operations )

//Get All Videos Above a certain view count ( Linear Search )



