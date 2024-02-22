public class BookByTheme
{
    public string? Theme { get; set; }
    public List<string> Titles { get; set; }
    public BookByTheme(string? theme, List<string> titles)
    {
        Theme = theme;
        Titles = titles;
    }
    public BookByTheme() 
    {
    }
}
