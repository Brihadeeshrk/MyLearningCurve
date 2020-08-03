using System;
using System.Collections.Generic;

namespace CSharp1
{
    class ExceptionHandling
    {

    }

    public class Video
    {
    }

    public class Calculator
    {
        public int Divide(int numerator, int denomenator)
        {
            return numerator / denomenator;
        }
    }

    public class YouTubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                // Access YouTube web service 
                // Read the data 
                // Create a list of Video objects
                throw new Exception("Oops some low level YouTube error.");
            }
            catch (Exception ex)
            {
                // Log 

                throw new YouTubeException("Could not fetch the videos from YouTube.", ex);
            }

            return new List<Video>();
        }
    }

    public class YouTubeException : Exception
    {
        public YouTubeException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }

}
