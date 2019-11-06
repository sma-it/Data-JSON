using MovieDB.Data;
using MovieDB.Views;
using System;

namespace MovieDB
{
    class Program
    {
        static void Main(string[] args)
        {
            var store = new DataStore();

            var menu = new SMUtils.Menu();
            menu.AddOption('1', "Set User Details", () => store.Data.UserDetails = UserView.CreateUser());
            menu.AddOption('2', "Show User Details", () => UserView.ShowUser(store.Data.UserDetails));

            menu.AddOption('3', "Add Movie", () => store.Data.Movies.Add(MovieView.CreateMovie()));
            menu.AddOption('4', "Show Movies", () => MovieView.ShowMovies(store.Data.Movies));

            menu.Start();

            // we get here after exiting the menu
            store.SaveData();
        }
    }
}
