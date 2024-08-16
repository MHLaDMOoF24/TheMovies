using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.IO;

namespace TheMovies._2ViewModel
{
    internal class Datahandler
    {
        string filePath;
        string fileName;

        internal Datahandler()
        {   // Temporary setters for now, expand later?
            // Also set these to actual things!
            filePath = string.Empty;
            fileName = string.Empty;
        }

        public void SaveMovies(ObservableCollection<MovieViewModel> movies)
        {
            using (StreamWriter sw = new StreamWriter(Path.Combine(filePath, fileName), false))
            {
                try
                {
                    foreach (MovieViewModel movie in movies)
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

        public ObservableCollection<MovieViewModel> LoadMovies()
        {
            if (File.Exists(Path.Combine(filePath, fileName)))
            {
                ObservableCollection<MovieViewModel> movies = new ObservableCollection<MovieViewModel>();
                using (StreamReader sr = new StreamReader(Path.Combine(filePath, fileName)))
                {
                    while (!sr.EndOfStream) 
                    {
                        string value;

                    }
                }
                return movies;
            }
            else
                return null;
        }
    }
}
