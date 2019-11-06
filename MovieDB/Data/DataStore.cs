using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieDB.Data
{
    class ProjectData
    {
        public Models.User UserDetails { get; set; } = new Models.User();
        public List<Models.Movie> Movies { get; set; } = new List<Models.Movie>();
    }

    class DataStore
    {
        ProjectData data;

        public Models.User User => data.UserDetails;
        public List<Models.Movie> Movies => data.Movies;

        public void SetUser(Models.User user)
        {
            data.UserDetails = user;
        }

        public void AddMovie(Models.Movie movie)
        {
            data.Movies.Add(movie);
        }

        public DataStore()
        {
            if(System.IO.File.Exists("data.json"))
            {
                var input = System.IO.File.ReadAllText("data.json");
                data = JsonConvert.DeserializeObject<ProjectData>(input);
            } else
            {
                data = new ProjectData();
            }
        }

        public void SaveData()
        {
            var content = JsonConvert.SerializeObject(data, Formatting.Indented);
            System.IO.File.WriteAllText("data.json", content);
        }
    }
}
