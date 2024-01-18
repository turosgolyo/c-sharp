using CustomLibrary.ConsoleExtensions;
const int NUMBER_OF_SONGS = 2;

Song[] songs = GetSongs();
PrintSongsToConsole(songs);

double average = GetAverageLenght(songs);
Console.WriteLine($"\nA számok hossza átlagosan: {average:F0}s");

Song[] GetSongs()
{
    Random random = new Random();

    Song[] songs = new Song[NUMBER_OF_SONGS];
    int number = 0;
    for (int i = 0; i < NUMBER_OF_SONGS; i++)
    {
        string name = ExtendedConsole.ReadString($"{i + 1}. Dal:");
        number++;
        songs[i] = new Song(name, number, random.Next(20, 501));
    }
    return songs;
}
double GetAverageLenght(Song[] songs) => songs.Average(x => x.Length);
void PrintSongsToConsole(Song[] songs)
{
    foreach(Song song in songs)
    {
        Console.WriteLine(song);
    }
}