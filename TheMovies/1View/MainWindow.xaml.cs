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

namespace TheMovies._1View
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnMovies_Click(object sender, RoutedEventArgs e)
        {
            // Instantiate the CreateDiscount window
            Movies movies = new Movies();

            // Shows the desired window
            movies.Show();

            // Closes the current window (MainWindow)
            this.Close();
        }
    }
}
