using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class MoviesByRating
{
    public List<string> Name { get; set; }
    public string Rating { get; set; }
    public MoviesByRating(List<string> name, string rating)
    {
        Name = name;
        Rating = rating;
    }
    public MoviesByRating()
    {
    }
}