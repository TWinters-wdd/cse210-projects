public class Videos
{
    private List<Video> _videos = new List<Video>();

    public void AddVideo(Video video)
    {
        _videos.Add(video);
    }

    public void DisplayVideos()
    {
        foreach (Video video in _videos)
        {
            Console.WriteLine($"{video.GetVideoString()}\n");
            video.DisplayComments();
            Console.WriteLine();
        }
    }
}