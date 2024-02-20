internal class Book
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string BirthDate { get; set; }
    public string Title { get; set; }
    public string ISBN { get; set; }
    public string Publisher { get; set; }
    public int ReleaseDate{ get; set; }
    public int Price{ get; set; }
    public string Theme { get; set; }
    public int PageCount { get; set; }
    public int Honorarium { get; set; }
    
    public Book(string firstName, string lastName, string birthDate, string title, string iSBN, string publisher, int releaseDate, int price, string theme, int pageCount, int honorarium)
    {
        FirstName = firstName;
        LastName = lastName;
        BirthDate = birthDate;
        Title = title;
        ISBN = iSBN;
        Publisher = publisher;
        ReleaseDate = releaseDate;
        Price = price;
        Theme = theme;
        PageCount = pageCount;
        Honorarium = honorarium;
    }

    public Book()
    {
    }

    public override string ToString()
    {
        return $"{this.FirstName} {this.LastName}({this.BirthDate}) - {this.Title} - {this.ReleaseDate} - {this.Price} Ft - {this.Theme} - ISBN: {this.ISBN} - Kiadó: {this.Publisher} - {this.PageCount} - {this.Honorarium} Ft";
    }
}

    /*Vezetéknév (íróé),
    Keresztnév (íróé),
    SzületésiDátum,
    Cím,
    ISBN,
    Kiadó,
    KiadvasiÉv,
    ár,
    Téma,
    Oldalszám,
    Honorárium (amit a könyvért kapott az író)*/
