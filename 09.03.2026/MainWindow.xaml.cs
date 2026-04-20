using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace _09._03._2026
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Movie> Movies { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Movies = new ObservableCollection<Movie>
            {
                new Movie { Title = "Inception", Year = 2010, Genre = "Sci-Fi", Length = 148, Imdb = 8.8, Csfd = 90, Rotten = 87 },
                new Movie { Title = "The Dark Knight", Year = 2008, Genre = "Action", Length = 152, Imdb = 9.0, Csfd = 93, Rotten = 94 },
                new Movie { Title = "Interstellar", Year = 2014, Genre = "Sci-Fi", Length = 169, Imdb = 8.6, Csfd = 89, Rotten = 73 },
                new Movie { Title = "Titanic", Year = 1997, Genre = "Drama", Length = 195, Imdb = 7.9, Csfd = 87, Rotten = 88 }
            };

            DataContext = this;
        }

        private void FilterChanged(object sender, EventArgs e)
        {
            if (Movies == null)
                return;

            string selectedGenre = (GenreFilter.SelectedItem as ComboBoxItem)?.Content?.ToString();

            var filtered = Movies.Where(m =>
                (string.IsNullOrWhiteSpace(SearchBox.Text) ||
                 m.Title.Contains(SearchBox.Text, StringComparison.OrdinalIgnoreCase)) &&

                (string.IsNullOrEmpty(selectedGenre) ||
                 selectedGenre == "All" ||
                 m.Genre == selectedGenre)
            ).ToList();

            MoviesGrid.ItemsSource = filtered;
        }

        private void DeleteMovie_Click(object sender, RoutedEventArgs e)
        {
            if (MoviesGrid.SelectedItem is Movie selected)
            {
                Movies.Remove(selected);
            }
        }
    }
}