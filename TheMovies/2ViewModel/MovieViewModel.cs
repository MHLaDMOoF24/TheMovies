using System.Collections.ObjectModel;
using TheMovies._3Model;
using TheMovies.MVVM;

namespace TheMovies._2ViewModel
{
    internal class MovieViewModel : ViewModelBase
    {
        private Datahandler _datahandler = new Datahandler();

        public ObservableCollection<Movie> Movies { get; set; }

        private Movie _selectedMovie;
        public Movie SelectedMovie
        {
            get { return _selectedMovie; }
            set
            {
                _selectedMovie = value;
                OnPropertyChanged();
            }
        }

        // Relay commands for binding
        public RelayCommand AddCommand => new RelayCommand(execute => AddItem());
        public RelayCommand DeleteCommand => new RelayCommand(execute => DeleteItem(), canExecute => SelectedMovie != null);
        public RelayCommand SaveCommand => new RelayCommand(execute => Save(), canExecute => CanSave());

        //public MovieViewModel() { }
        public MovieViewModel(MainViewModel mainVM)
        {
            // Read mainVM information into workspace collection
            Movies = new ObservableCollection<Movie>(mainVM.movieRepo.Read());
        }

        // Methods that commands execute
        private void AddItem()
        {
            Movies.Add(new Movie("", "00:00", ""));
        }

        private void DeleteItem()
        {
            Movies.Remove(SelectedMovie);
        }

        private void Save()
        {
            _datahandler.SaveMovies(Movies.ToList());
        }

        private bool CanSave()
        {
            return true;
        }
    }
}
