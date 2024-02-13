using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;

List<Movie> LoadData()
{
    JsonSerializerOptions options = new JsonSerializerOptions
    {
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        PropertyNameCaseInsensitive = true,
        WriteIndented = true,
    };

    options.Converters.Add(new DateFormatConverter());

    FileStream fs = new FileStream("./../../../data.json", FileMode.Open, FileAccess.Read, FileShare.None);
    StreamReader sr = new StreamReader(fs, Encoding.UTF8);
    
    string jsonData = sr.ReadToEnd();
    return JsonSerializer.Deserialize<List<Movie>>(jsonData, options);

}

 void WriteToConsole(string text, ICollection<Movie> movies)
{
    Console.WriteLine(text);
    Console.WriteLine(string.Join('\n', movies));
}

 void WriteSingleToConsole(string text, Movie movie)
{
    Console.WriteLine(text);
    Console.WriteLine(movie);
}


List<Movie> movies = LoadData();
WriteToConsole($"Data ({movies.Count})", movies);

// 1 - Hány film adatát dolgozzuk fel?
int count = movies.Count;


// 2 - Mekkora bevételt hoztak a filmek Amerikában?
long USGrossSum = movies.Where(x => x.USGross != null)
                       .Sum(x => x.USGross.Value);

USGrossSum = movies.Sum(x => x.USGross ?? 0);


// 3 - Mekkora bevételt hoztak a filmek Világszerte?
long globalGrossSum = movies.Sum(x => x.WorldwideGross ?? 0);


// 4 - Hány film jelent meg az 1990-es években?
int moviesReleasedIn90s = movies.Count(x => x.ReleaseDate.Year >= 1990 && x.ReleaseDate.Year < 2000);


// 5 - Hányan szavaztak összessen az IMDB-n?
long voteCounts = movies.Where(x => x.IMDBVotes.HasValue)
                        .Sum(x => x.IMDBVotes.Value);

// 6 - Hányan szavaztak átlagossan az IMDB-n?
double voteAverage = movies.Where(x => x.IMDBVotes.HasValue)
                           .Average(x => x.IMDBVotes.Value);


// 7 - A filmek  világszerte átlagban mennyit hoztak a konyhára?
double averageGrossIncome = movies.Average(x => x.WorldwideGross ?? 0);

// 8 - Hány filmet rendezett 'Christopher Nolan' ?
int countMoviesDirectedByChristopherNolan = movies.Count(x => x.Director?.ToLower() == "christopher nolan");

// 9 - Melyik filmeket rendezte 'James Cameron'?
List<Movie> moviesDirectedByJamesCameron = movies.Where(x => x.Director?.ToLower() == "james cameron").ToList();

// 10 - Keresse ki a 'Fantasy' kaland (Adventure) zsáner kategóriájjú filmeket.
List<Movie> adventureMovies = movies.Where(x => x.MajorGenre?.ToLower() == "fantasy").ToList();

// 11 - Kik rendeztek akció (Action) filmeket és mikor?
List<ActionMovies> actionDirectors = movies.Where(x => x.MajorGenre == "Action")
                                           .Where(x => x.Director != null)
                                           .GroupBy(x => x.Director)
                                           .Select(x => new ActionMovies
                                           {
                                               Name = x.Key,
                                               Times = x.Select(x => x.ReleaseDate).ToList()
                                           }).ToList();
// 12 - 'Paramount Pictures' horror filmjeinek cime?
List<string> paramountHorrorMovies = movies.Where(x => x.Distributor == "Paramount Pictures")
                                           .Select(x => x.Title)
                                           .ToList();

// 13 - Van-e olyan film melyet 'Tom Crusie' rendezett?
bool anyFilmsDirectedByTomCrouise = movies.Any(x => x.Director == "Tom Cruise");

// 14 - A 'Little Miss Sunshine' filme mekkora össz bevételt hozott?
long? littleMissSunshineGross = movies.Where(x => x.Title == "Little Miss Sunshine").Sum(x => x.WorldwideGross);

// 15 - Hány olyan film van amely az IMDB-n 6 feletti osztályzatot ért el és a 'Rotten Tomatoes'-n pedig legalább 25-t?
int IMDB6AndRottenTomatoes25Rating = movies.Count(x => x.IMDBRating >= 6 && x.RottenTomatoesRating >= 25);

// 16 - 'Michael Bay' filmjei átlagban mekkora bevételt hoztak?
double? michaelBayAverageGross = movies.Where(x => x.Director == "Michael Bay").Average(x => x.WorldwideGross);

// 17 - Melyek azok a 'Michael Bay' a 'Walt Disney Pictures' által forgalmazott fimek melyek legalább 150min hosszúak.
List<Movie> michaelBayDisneyMovies = movies.Where(x => x.Director == "Michael Bay" && x.Distributor == "Walt Disney" && x.RunningTime >= 150).ToList();


// 18 - Listázza ki a forgalmazókat úgy, hogy mindegyik csak egyszer jelenjen meg!
List<string> distributors = movies.Select(x => x.Distributor).Distinct().ToList();


// 19 - Rendezze a filmeket az 'IMDB Votes' szerint  növekvő sorrendbe.
List<Movie> orderMoviesByIMDB = movies.OrderBy(x => x.IMDBVotes).ToList();

// 20 - Rendezze a filmeket címük szerint csökkenő sorrendbe!
List<Movie> orderMoviesByTitle = movies.OrderByDescending(x => x.Title).ToList();

// 21 - Melyek azok a filmek melyek hossza meghaladja a 120 percet?
List<Movie> moviesLongerThan120Minutes = movies.Where(x => x.RunningTime >= 120).ToList();

// 22 - Hány film jelent meg december hónapban?
int moviesReleasedInDec = movies.Count(x => x.ReleaseDate.Month == 12);


// 23 - Egyes besorolásokban (Rating) hány film található?
List<MoviesByRating> moviesByRating = movies.GroupBy(x => x.Rating)
                                            .Select(x => new MoviesByRating
                                            {
                                               Rating = x.Key,
                                               Name = x.Select(x => x.Title).ToList()
                                            }).ToList();



// 24 - Keresse ki azokat a filmeket melyeket 'Ron Howard' rendezett a 2000 években, 'PG-13' bsorolású, lagalább 80 perc hosszú és az IMDB legalább 6.5 átlagot ért el.
List<Movie> idk = movies.Where(x => x.Director == "Ron Howard" && x.ReleaseDate.Year >= 2000 && x.Rating == "PG-13" && x.RunningTime >= 80 && x.IMDBRating >= 6.5).ToList();



// 25 - A 'Lionsgate' kiadónál kik rendeztek filmeket?
List<string> lionsgateDirectors = movies.Where(x => x.Distributor == "Lionsgate").Select(x => x.Director).Distinct().ToList();



// 26 - Az 'Universal' forgalmazó átlagban mennyit kültött film forgatására?
double? universalAverage = movies.Where(x => x.Distributor == "Universal").Average(x => x.ProductionBudget);



// 27 - Az 'IMDB Votes' alapján melyek azok a filmek, melyeket többen értékeltek min 30 000-n?
List<Movie> imdbVotesOver30000 = movies.Where(x => x.IMDBVotes >= 30000).ToList();


// 28 - Az 'American Pie' című filmnek hány része van?
int americanPiePartCount = movies.Count(x => x.Title?.ToLower().StartsWith("american pie") ?? false);


// 29 - Van-e olyan film melynek a címében szerepel a 'fantasy' szó és a zsánere 'Adventure'?
bool anyFantasyAdventureMovires = movies.Any(x => x.Title?.ToLower().Contains("fantasy") ?? false && x.MajorGenre == "Adventure");


// 30 - Átlagban hányan szavaztak az IMDB-n?
double? averageIMDBVotes = movies.Average(x => x.IMDBVotes);


// 31 - Kik rendeztek a 'Warner Bros.' forgalmazónál dráma filmeket 1970 és 1975 közt melyre az 'IMDB Votes' alapján többen szavaztak az átlagnál?
List<string> ahanemtom = movies.Where(x => x.Distributor == "Warner Bros." && x.ReleaseDate.Year >= 1970 && x.ReleaseDate.Year >= 1975 && x.IMDBVotes >= averageIMDBVotes).Select(x => x.Director).Distinct().ToList();


// 32 - Van e olyan film amely karácsony napján jelent meg?
bool anyMoviesReleasedOnXmas = movies.Any(x => x.ReleaseDate.Month == 12 && x.ReleaseDate.Day == 25);

// 33 - 'Spider-Man' című filmek USA-ban mekkora bevételt hoztak?
long? spidermanGross = movies.Where(x => x.Title.Contains("Spider-Man")).Sum(x => x.WorldwideGross);



// 34 - Keresse ki  szuperhősös (Super Hero) filmek címeit.
List<string> superheroMovies = movies.Where(x => x.CreativeType == "Super Hero").Select(x => x.Title).ToList();


// 35 - elso tiz film
List<Movie> first10Movies = movies.Take(10).ToList();

// 36 - feladat?
List<Movie> page3 = movies.Skip(30).Take(10).ToList();
