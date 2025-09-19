namespace Proxy.VideoExample
{
    // Proxy
    public class ProxyVideo : IVideo
    {
        private RealVideo realVideo;
        private string fileName;

        public ProxyVideo(string fileName)
        {
            this.fileName = fileName;
        }

        public void Play()
        {
            // Chỉ load video khi thực sự cần
            if (realVideo == null)
            {
                realVideo = new RealVideo(fileName);
            }
            realVideo.Play();
        }
    }
}
