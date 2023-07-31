using PhiloStory2.Core;

namespace PhiloStory2.MVVM.ViewModel
{
	internal class LibraryViewModel : ObservableObject
	{
		public FooterViewModel FooterVM { get; set; }

		private object footerView;

		public object FooterView
		{
			get { return footerView; }
			set { footerView = value; OnPropertyChanged(); }
		}

        public LibraryViewModel()
        {
            FooterVM = new FooterViewModel();
			FooterView = FooterVM;
        }
    }
}
