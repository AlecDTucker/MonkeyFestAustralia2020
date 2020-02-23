using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MonkeyFestAustralia2020
{
    public class CollectionExampleViewModel : BaseViewModel
    {
        #region Constructors & initialisation
        public CollectionExampleViewModel()
        {
            // LoadData();
        }
        #endregion

        #region Properties
        private ObservableCollection<Book> _books;
        public ObservableCollection<Book> Books { get => _books; set => SetProperty(ref _books, value); }

        private bool _isBusy;
        public bool IsBusy { get => _isBusy; set => SetProperty(ref _isBusy, value); }
        #endregion

        #region Commands
        private ICommand _refreshCommand = null;
        public ICommand RefreshCommand => _refreshCommand = _refreshCommand ?? new Command(async () => await DoRefreshCommand());
        #endregion

        #region Methods
        private async Task DoRefreshCommand()
        {
            IsBusy = true;
            await LoadData();
            IsBusy = false;
        }

        private async Task LoadData()
        {
            List<Book> books = new List<Book>()
            {
                new Book() { Id = "1", Author = "Willy Makeit", Title = "Running for the bus", Description = "Illustrated by Betty Wont"},
                new Book() { Id = "2", Author = "Mo T. Vator", Title = "How to climb the stairs in 10 easy steps", Description = "What you do when you get there is another storey!" },
                new Book() { Id = "3", Author = "Miles Franklin", Title = "My Brilliant Career", Description = "Sybylla is a bundle of contradictions: a charming tomboy who likes to wear a pretty dress, a self-pitying soul yearning to be loved, yet shunning romance when it presents itself. She grows up on a lush property in NSW until her father buys drought-stricken land in Possum Gully and gambles and drinks away the family’s earnings. Sybylla is sent to live with her grandmother and aunt on a property that sounds like the Australian settler’s holy land, all flowing streams and lush ferns and the warble of birdsong." },
                new Book() { Id = "4", Author = "Ruth Park", Title = "The Harp in the South", Description = "New Zealand-born Park has been a steady Australian favourite for over half a century, and The Harp In The South has never been out of print since it was published." },
                new Book() { Id = "5", Author = "Patrick White", Title = "Voss", Description = "Voss, a fictionalised account of the Australian expeditions of explorer Ludwig Leichardt, won its author the inaugural Miles Franklin Award in 1957, and is listed on pretty much every “Best Australian Book” list there is." },
            };

            await Task.Delay(2000);

            Books = new ObservableCollection<Book>(books);
        }
        #endregion
    }
}
