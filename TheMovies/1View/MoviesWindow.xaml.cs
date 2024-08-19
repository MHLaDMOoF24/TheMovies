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
        MovieViewModel movieVM;
        MainViewModel mainVM;

        public MoviesWindow(MainViewModel mainViewModel)
        {
            InitializeComponent();

            this.mainVM = mainViewModel;
            DataContext = this.mainVM;
        }

        private void dgMovies_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnCreateMovie_Click(object sender, RoutedEventArgs e)
        {
            mainVM.NewMovie();
        }

        private void btnDeleteMovie_Click(object sender, RoutedEventArgs e)
        {
            mainVM.DeleteMovie(dgMovies.SelectedIndex);
        }

        private void tbTitle_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnCloseWindow_Click(object sender, RoutedEventArgs e)
        {
            // Resets selection to avoid an error
            dgMovies.SelectedIndex = 0;

            // Save movies to file
            mainVM.SaveMovies();

            Close();
        }
    }
}
