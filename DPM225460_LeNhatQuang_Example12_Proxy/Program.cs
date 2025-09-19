using Proxy.VideoExample;
using System;

namespace DPM225460_LeNhatQuang_Example12_Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            IVideo video1 = new ProxyVideo("movie_trailer.mp4");
            IVideo video2 = new ProxyVideo("music_video.mp4");

            Console.WriteLine("=== User browsing the list, but not playing yet ===");

            // Khi user chọn play, video mới load
            Console.WriteLine("\n--- User clicks play on trailer ---");
            video1.Play();

            Console.WriteLine("\n--- User clicks play on music video ---");
            video2.Play();

            Console.WriteLine("\n--- User replays trailer (already cached) ---");
            video1.Play();

            Console.ReadKey();
        }
    }
}
