using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Movies_Project
{
    /// <summary>
    /// Interaction logic for CinemaWindow.xaml
    /// </summary>
    public partial class CinemaWindow : Window
    {
        CinemasEntities db = new CinemasEntities();
        public CinemaWindow()
        {
            InitializeComponent();
        }

        private ObservableCollection<Cinema> GetData()
        {
            var query1 = (from c in db.CinemaTbls
                            where c.CinemaId == 1
                        select new
                        {
                           CinemaName = c.CinemaName,
                           CinemaAddress = c.CinemaAddress,
                            CinemaEmail =  c.CinemaEmail,
                            CinemaNumber = c.CinemaPhoneNum,
                            CinemaId = c.CinemaId
                        }).FirstOrDefault();

            var query2 = (from c in db.CinemaTbls
                          where c.CinemaId == 2
                          select new
                          {
                              CinemaName = c.CinemaName,
                              CinemaAddress = c.CinemaAddress,
                              CinemaEmail = c.CinemaEmail,
                              CinemaNumber = c.CinemaPhoneNum,
                              CinemaId = c.CinemaId
                          }).FirstOrDefault();

            var query3 = (from c in db.CinemaTbls
                          where c.CinemaId == 3
                          select new
                          {
                              CinemaName = c.CinemaName,
                              CinemaAddress = c.CinemaAddress,
                              CinemaEmail = c.CinemaEmail,
                              CinemaNumber = c.CinemaPhoneNum,
                              CinemaId = c.CinemaId
                          }).FirstOrDefault();



            Cinema c1 = new Cinema()
            {
                CinemaName = query1.CinemaName,
                CinemaAddress = query1.CinemaAddress,
                CinemaEmail = query1.CinemaEmail,
                CinemaNumber = query1.CinemaNumber,
                CinemaId = query1.CinemaId
            };

            Cinema c2 = new Cinema()
            {
                CinemaName = query2.CinemaName,
                CinemaAddress = query2.CinemaAddress,
                CinemaEmail = query2.CinemaEmail,
                CinemaNumber = query2.CinemaNumber,
                CinemaId = query2.CinemaId
            };

            Cinema c3 = new Cinema()
            {
                CinemaName = query3.CinemaName,
                CinemaAddress = query3.CinemaAddress,
                CinemaEmail = query3.CinemaEmail,
                CinemaNumber = query3.CinemaNumber,
                CinemaId = query3.CinemaId
            };

            ObservableCollection<Cinema> cinemas = new ObservableCollection<Cinema>();
            cinemas.Add(c1);
            cinemas.Add(c2);
            cinemas.Add(c3);

            return cinemas;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lboxCinemas.ItemsSource = GetData();
        }

        private void lboxCinemas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Cinema selectedCinema = lboxCinemas.SelectedItem as Cinema;

            if (selectedCinema != null)
                spCinemaDetails.DataContext = selectedCinema;

            var query = from m in db.MovieTbls
                        join c in db.CinemaTbls on m.CinemaId equals c.CinemaId
                        orderby m.MovieId ascending
                        where m.CinemaId == selectedCinema.CinemaId
                        select new
                        {
                            m.MovieTitle,
                            m.MovieRunTime
                        };

            dgAvailableMovies.ItemsSource = query.ToList();
        }
    }
}
