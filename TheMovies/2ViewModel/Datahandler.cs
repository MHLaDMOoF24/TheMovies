using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.IO;
using TheMovies._3Model;

namespace TheMovies._2ViewModel
{
    internal class Datahandler
    {
        string filePath;
        string fileName;

        internal Datahandler()
        {   // Temporary setters for now, expand later?
            // Also set these to actual things!
            filePath = Directory.GetCurrentDirectory();
            fileName = "movies.csv";
        }

        // Currently specific to MainViewModel
        public void SaveMovies(List<Movie> movies)
        {
            using (StreamWriter sw = new StreamWriter(Path.Combine(filePath, fileName), false))
            {
                try
                {
                    foreach (Movie movie in movies)
                    {
                        sw.WriteLine(movie.ToString());
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Exception: {e.Message}");
                }
            }
        }

        // Currently specific to MovieRepository
        public List<Movie> LoadMovies()
        {
            if (File.Exists(Path.Combine(filePath, fileName)))
            {
                List<Movie> movies = new List<Movie>();
                using (StreamReader sr = new StreamReader(Path.Combine(filePath, fileName)))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(";");

                        movies.Add(new Movie(line[0], line[1], line[2]));
                    }
                }
                return movies;
            }
            else
                return new List<Movie>();
        }
    }
}
