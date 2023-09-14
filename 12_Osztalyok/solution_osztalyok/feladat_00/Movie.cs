public class Movie
    {
    public string MovieName { get; set; }
    public string MovieMainCharacter { get; set; }
    public string MovieRating { get; set; }
    public double MovieLenght { get; set; }
    public int ReleaseYear { get; set; }

    public override string ToString()
    {
        return $"Film neve: {this.MovieName}, film hossza: {this.MovieLenght} óra, főszereplő: {this.MovieMainCharacter}, kiadási év: {this.ReleaseYear}, besorolás: {this.MovieRating}";
    }
}
