using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TheMovies._2ViewModel;

namespace TheMovies._1View
{
    /// <summary>
    /// Interaction logic for Movies.xaml
    /// </summary>
    public partial class MoviesWindow : Window
    {
        internal MovieViewModel movieVM;

        public MoviesWindow(MainViewModel mainVM)
        {
            InitializeComponent();

            // Grab information from Main
            movieVM = new MovieViewModel(mainVM);

            DataContext = movieVM;
        }

        private void dgMovies_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnCreateMovie_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDeleteMovie_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
