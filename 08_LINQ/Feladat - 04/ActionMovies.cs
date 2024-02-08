using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class ActionMovies
{
    public string Name { get; set; }
    public List<DateTime> Times { get; set; }
    public ActionMovies(string name, List<DateTime> times)
    {
        Name = name;
        Times = times;
    }
}