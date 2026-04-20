using System.Windows;

namespace _09._03._2026
{
    public partial class MovieWindow : Window
    {
        public Movie Movie { get; set; }

        public MovieWindow(Movie movie = null)
        {
            InitializeComponent();

            if (movie != null)
            {
                Movie = movie;

                TitleBox.Text = movie.Title;
                YearBox.Text = movie.Year.ToString();
                GenreBox.Text = movie.Genre;
                LengthBox.Text = movie.Length.ToString();
                ImdbBox.Text = movie.Imdb.ToString();
                CsfdBox.Text = movie.Csfd.ToString();
                RottenBox.Text = movie.Rotten.ToString();
            }
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            Movie = new Movie
            {
                Title = TitleBox.Text,
                Year = int.TryParse(YearBox.Text, out int y) ? y : 0,
                Genre = GenreBox.Text,
                Length = int.TryParse(LengthBox.Text, out int l) ? l : 0,
                Imdb = double.TryParse(ImdbBox.Text, out double i) ? i : 0,
                Csfd = double.TryParse(CsfdBox.Text, out double c) ? c : 0,
                Rotten = int.TryParse(RottenBox.Text, out int r) ? r : 0
            };

            DialogResult = true;
            Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}