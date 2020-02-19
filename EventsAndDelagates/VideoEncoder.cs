using System;
using System.Threading;

namespace EventsAndDelagates
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
    public class VideoEncoder
    {
        //----------------
        // 1 - Define a delegate
        // 2 - Define an event based on that delegate
        // 3 - Raise the event
        //----------------

        // 1
        //First try:
        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        
        // EventHandler
        // EventHandler<TEventArgs>
        // Easy way
        public event EventHandler<VideoEventArgs> VideoEncoded;

        // 2



        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        // Convention: Event publisher methods should be protected, virtual and void
        // For the naming it should start with "On" and the name of the event OnVideoEncoded()

        // 3
        protected virtual void OnVideoEncoded(Video video)
        {
            if(VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() { Video = video });
            }
        }
    }
}
