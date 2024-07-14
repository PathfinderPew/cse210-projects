class Program
{
    static void Main(string[] args)
    {
        YouTubeVideo video = new YouTubeVideo("Python Tutorial", "Learn Python programming.", "2024-07-13", 1500);
        video.DisplayVideoDetails();
        video.PlayVideo();
        video.LikeVideo();
        video.DisplayVideoDetails();
    }
}
