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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        MainViewModel mainVM;

        MoviesWindow moviesWindow;

        public MainWindow()
        {
            InitializeComponent();

            mainVM = new MainViewModel();
        }
        private void btnMovies_Click(object sender, RoutedEventArgs e)
        {
            moviesWindow = new MoviesWindow(mainVM);
            moviesWindow.Show();
            //// Instantiate the CreateDiscount window
            //Movies movies = new Movies();

            //// Shows the desired window
            //movies.Show();

            //// Closes the current window (MainWindow)
            //this.Close();
        }
    }
}
