namespace Proxy.VideoExample
{
    // RealSubject (đối tượng thật, nặng)
    public class RealVideo : IVideo
    {
        private string fileName;

        public RealVideo(string fileName)
        {
            this.fileName = fileName;
            LoadFromServer();
        }

        private void LoadFromServer()
        {
            Console.WriteLine($"[RealVideo] Loading video '{fileName}' from server...");
            // Giả lập tải video nặng
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine($"[RealVideo] Finished loading '{fileName}'.");
        }

        public void Play()
        {
            Console.WriteLine($"[RealVideo] Playing video: {fileName}");
        }
    }
}
