internal class Music
    {
    public string MusicTitle { get; set; }
    public string MusicArtist { get; set;}
    public double MusicLenght { get; set;}
    public int MusicReleaseYear { get; set;}
    public string MusicPlatform { get; set;}
    public override string ToString()
    {
        return $"Zene címe: {this.MusicTitle}\nElőadó: {this.MusicArtist}\nZene hossza: {this.MusicLenght} perc\nKiadási év: {this.MusicReleaseYear}\nPlatform: {this.MusicPlatform}";
    }
}

