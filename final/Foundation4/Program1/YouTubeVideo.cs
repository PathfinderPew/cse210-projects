public class YouTubeVideo
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string UploadDate { get; set; }
    public int Views { get; set; }
    public int Likes { get; private set; }
    public bool IsPlaying { get; private set; }

    public YouTubeVideo(string title, string description, string uploadDate, int views)
    {
        Title = title;
        Description = description;
        UploadDate = uploadDate;
        Views = views;
        Likes = 0;
        IsPlaying = false;
    }

    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Upload Date: {UploadDate}");
        Console.WriteLine($"Views: {Views}");
        Console.WriteLine($"Likes: {Likes}");
    }

    public void PlayVideo()
    {
        IsPlaying = true;
        Console.WriteLine($"Playing {Title}...");
    }

    public void LikeVideo()
    {
        Likes++;
        Console.WriteLine($"{Title} now has {Likes} likes.");
    }
}
