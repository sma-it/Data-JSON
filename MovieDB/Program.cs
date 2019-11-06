using MovieDB.Data;
using MovieDB.Views;
using System;

namespace MovieDB
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a datastore
            var store = new DataStore();

            // create a menu
            var menu = new SMUtils.Menu();

            // call view to create user, and pass the new user to the store
            menu.AddOption('1', "Set User Details", () => store.SetUser(UserView.CreateUser()));
            // call view to show user, and pass the store user as an argument
            menu.AddOption('2', "Show User Details", () => UserView.ShowUser(store.User));

            // call view to create a movie, and use a function to add it to the store
            menu.AddOption('3', "Add Movie", () => store.AddMovie(MovieView.CreateMovie()));

            // call view to show movies and pass the list of movies from the store
            menu.AddOption('4', "Show Movies", () => MovieView.ShowMovies(store.Movies));

            // start running the menu
            menu.Start();

            // we get here after exiting the menu. Save the data to a json file
            store.SaveData();
        }
    }
}
