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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using Newtonsoft.Json;

namespace Movies_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Movie> movies = new List<Movie>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Cinema_Button_Click(object sender, RoutedEventArgs e)
        {
            var window = new CinemaWindow();
            window.Show();
        }

        public List<Movie> ReadJsonString()
        {
            string json = File.ReadAllText(@".\moviedata.json");

            movies = JsonConvert.DeserializeObject<List<Movie>>(json);
            return movies;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ReadJsonString();

            lboxMovies.ItemsSource = movies.ToList();
        }

        private void lboxMovies_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Movie selectedMovie = (Movie)lboxMovies.SelectedItem;

            string selectedMovieTitle = selectedMovie.Title.ToString();
            string selectedMovieDirector = selectedMovie.Director.ToString();
            string selectedMovieGenre = selectedMovie.Genre.ToString();
            string selectedMovieYear = selectedMovie.Released.ToString();
            string selectedMovieDescription = selectedMovie.Description.ToString();

            tboxDetails.Text = ($"Title: {selectedMovieTitle} \nDirector: {selectedMovieDirector} \nGenre: {selectedMovieGenre} \nYear Released: {selectedMovieYear} \nDescription: {selectedMovieDescription}");

            try
            {
                string selectedMoviePoster = selectedMovie.Poster.ToString();
                imgPoster.Source = new BitmapImage(new Uri(GetImageDirectory() + selectedMoviePoster, UriKind.Absolute));
            }

            catch (FileNotFoundException fnfe)
            {
                MessageBox.Show(string.Format("Error: {0}\nSource: {1}\n{2}", fnfe.Message, fnfe.Source, fnfe.StackTrace));
            }
        }
        
        private string GetImageDirectory()
        {
            string currentDir = Directory.GetCurrentDirectory();
            DirectoryInfo parent = Directory.GetParent(currentDir);
            DirectoryInfo grandParent = Directory.GetParent(parent.FullName);
            string imageDirectory = grandParent + "\\images\\";

            return imageDirectory;
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
