using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace MonkeyFestAustralia2020
{
    public class CarouselExampleViewModel : BaseViewModel
	{
		#region Constructors & initialisation
		public CarouselExampleViewModel()
		{
			LoadData();
		}
		#endregion

		#region Properties

		private ObservableCollection<Film> _films;
		public ObservableCollection<Film> Films { get => _films; set => SetProperty(ref _films, value); }

		#endregion

		#region Commands
		#endregion

		#region Methods
		private void LoadData()
		{
			List<Film> films = new List<Film>()
			{
				new Film() { Id = "1", Title = "Arrival", Tagline = "", Description = "Louise Banks, a linguistics expert, along with her team, must interpret the language of aliens who've come to earth in a mysterious spaceship.", ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRmn4A0eiVOH4KoM8xqCxxNQM0NAY7lZQZ0glVIUIUOJYb9cryW"},
				new Film() { Id = "2", Title = "Edge of Tomorrow", Tagline = "", Description = "Smart, Exciting & Unexpected", ImageUrl = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcQxMJgknFpnvAXSdXOlU1gi0gDS7KClMOpt6uoGtaTRRJ0AIa5p" },
				new Film() { Id = "3", Title = "My Spy", Tagline = "", Description = "Nine-year-old Sophie catches JJ, a hardened CIA operative, spying on her family during a routine surveillance operation. In exchange for not blowing his cover, JJ begrudgingly agrees to show the precocious girl how to become a spy. What at first seems like an easy task soon turns into a battle of wits as Sophie proves you don't need much experience to outsmart a seasoned agent.", ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ-W-R2RiP3rmmmYsAgP0st6q1_otGR0cgxpFpM8UTnxoja0tuo" }
			};

			Films = new ObservableCollection<Film>(films);
		}
		#endregion
	}
}
