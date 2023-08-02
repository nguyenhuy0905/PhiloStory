using PhiloStory2.Core;

namespace PhiloStory2.MVVM.ViewModel
{
	internal class MainViewModel : ObservableObject
	{
		public HomeViewModel HomeVM { get; set; }
		public LibraryViewModel LibraryVM { get; set; }
		public ActivityViewModel ActivityVM { get; set; }
		public SettingViewModel SettingVM { get; set; }

		public RelayCommand NavHomeCommand { get; set; }
		public RelayCommand NavLibraryCommand { get; set; }
		public RelayCommand NavActivityCommand { get; set; }
		public RelayCommand NavSettingCommand { get; set; }

		private object _currentView;
		public object CurrentView
		{
			get { return _currentView; }
			set 
			{
				_currentView = value;
				OnPropertyChanged();
			}
		}

		private object _prevView;

		public object PreviousView
		{
			get { return _prevView; }
			set { _prevView = value; }
		}


		public MainViewModel()
        {
            HomeVM = new HomeViewModel();
			LibraryVM = new LibraryViewModel();
			CurrentView = HomeVM;			
			ActivityVM = new ActivityViewModel();
			SettingVM = new SettingViewModel();

			NavHomeCommand = new(o =>
			{
				PreviousView = CurrentView;
				CurrentView = HomeVM;				
			});
			NavLibraryCommand = new(o =>
			{
				PreviousView = CurrentView;
				CurrentView = LibraryVM;
			});
			NavActivityCommand = new(o =>
			{
				PreviousView = CurrentView;
				CurrentView = ActivityVM;
			});
			NavSettingCommand = new(o =>
			{
				PreviousView = CurrentView;
				CurrentView = SettingVM;
			});
        }

    }
}
