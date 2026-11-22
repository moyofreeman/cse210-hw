namespace YouTubeVideos;

public class Video
{
    public string _videoTitle;
    public string _videoAuthor;
    public int _videoLength;

    public List<Comment> _comments = new List<Comment>();

    public int NumberOfComments()
    {
        return _comments.Count;
    }
}