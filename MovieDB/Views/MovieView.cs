using System;
using System.Collections.Generic;
using System.Text;

namespace MovieDB.Views
{
class MovieView
{
    public static Data.Models.Movie CreateMovie()
    {
        var movie = new Data.Models.Movie();
        Console.Write("Enter a movie Name: ");
        movie.Name = Console.ReadLine();

        Console.Write("Year of Release: ");
        movie.Year = Convert.ToInt32(Console.ReadLine());

        var menu = new SMUtils.Menu();
        menu.AddOption('1', "Fantasy", () => movie.Genre = Data.Models.Genre.Fantasy);
        menu.AddOption('2', "SciFi", () => movie.Genre = Data.Models.Genre.SciFi);
        menu.AddOption('3', "Anime", () => movie.Genre = Data.Models.Genre.Anime);
        menu.AddOption('4', "Steampunk", () => movie.Genre = Data.Models.Genre.Steampunk);
        menu.AddOption('5', "Shenmo", () => movie.Genre = Data.Models.Genre.Shenmo);
        menu.AddOption('6', "Other", () => movie.Genre = Data.Models.Genre.Other);
        menu.Start(true);

        return movie;
    }

    public static void ShowMovie(Data.Models.Movie movie)
    {
        Console.WriteLine("Name : " + movie.Name);
        Console.WriteLine("Year : " + movie.Year);
        Console.WriteLine("Genre: " + movie.Genre.ToString());
    }

    public static void ShowMovies(List<Data.Models.Movie> list)
    {
        list.ForEach(item =>
        {
            ShowMovie(item);
            Console.WriteLine(); // add empty line
        });
    }
}
}
