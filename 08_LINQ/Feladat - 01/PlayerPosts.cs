public class PlayerPosts
{
    public string PostName { get; set; }
    public int PostCount { get; set; }
    public PlayerPosts()
    {
    }
    public PlayerPosts(string postName, int postCount)
    {
        PostName = postName;
        PostCount = postCount;
    }
} 