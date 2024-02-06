using System.Collections;
using System.Collections.Generic;

public class GamesMadeByDeveloper
{
    public string Developer { get; set; }
    public ICollection<string> Games { get; set; }
    public GamesMadeByDeveloper(string developer, ICollection<string> games) 
    {
        Developer = developer;
        Games = games;
    }

    public GamesMadeByDeveloper()
    {
    }
}

