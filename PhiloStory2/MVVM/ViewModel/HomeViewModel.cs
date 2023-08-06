using PhiloStory2.Core;

namespace PhiloStory2.MVVM.ViewModel
{
	internal class HomeViewModel : ObservableObject
	{
		public FooterViewModel FooterVM { get; set; }

		public LibraryViewModel LibraryVM { get; set; }

		public ActivityViewModel ActivityVM { get; set; }

		public RelayCommand NavLibraryCommand { get; set; }

		public RelayCommand NavActivityCommand { get; set; }

		private object footerView;

		public object FooterView
		{
			get { return footerView; }
			set { footerView = value; OnPropertyChanged(); }
		}


		public HomeViewModel() 
		{
			FooterVM = new FooterViewModel();

			FooterView = FooterVM;			
		}
	}
}
