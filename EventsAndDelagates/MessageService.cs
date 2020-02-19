using System;

namespace EventsAndDelagates
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MessageService: Sending an message..." + args.Video.Title);
        }
    }
}
