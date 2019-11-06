using System;
using System.Collections.Generic;
using System.Text;

namespace MovieDB.Views
{
class UserView
{
    public static Data.Models.User CreateUser()
    {
        var user = new Data.Models.User();
        Console.Write("Please enter your name: ");
        user.Name = Console.ReadLine();

        Console.Write("Please enter your age: ");
        user.Age = Convert.ToInt32(Console.ReadLine());

        return user;
    }

    public static void  ShowUser(Data.Models.User user)
    {
        Console.WriteLine("Name: " + user.Name);
        Console.WriteLine("Age : " + user.Age);
    }
}
}
