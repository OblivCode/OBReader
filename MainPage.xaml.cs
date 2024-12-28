namespace OBReader
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this; // Set the data context for binding
        }

        public List<Book> RecentBooks { get; } = new List<Book>()
        {
            // ... (Populate with your recent book data)
        };

        public List<Book> FavoriteBooks { get; } = new List<Book>()
        {
            // ... (Populate with your favorite book data)
        };

        public List<Book> LibraryPreviewBooks { get; } = new List<Book>()
        {
            // ... (Populate with your library preview book data)
        };

        private async void OnViewAllClicked(object sender, EventArgs e)
        {
            // Handle navigation to the full library view
            await Navigation.PushAsync(new LibraryPage()); // Example
        }
    }

}
