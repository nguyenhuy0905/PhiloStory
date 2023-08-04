using PhiloStory2.Core;

namespace PhiloStory2.MVVM.ViewModel
{
	internal class ActivityViewModel : ObservableObject
	{
		public FooterViewModel FooterVM { get; set; }

		public RelayCommand OpenTextEditorCommand => new(execute => OpenTextEditor());

		public TextEditorViewModel TextEditorVM { get; set; }

		private object _textEditor;

		public object TextEditor
		{
			get { return _textEditor; }
			set { _textEditor = value;
				OnPropertyChanged();
			}
		}


		private object footerView;

		public object FooterView
		{
			get { return footerView; }
			set { footerView = value;
				OnPropertyChanged();
			}
		}

		public ActivityViewModel() 
		{
			FooterVM = new FooterViewModel();
			FooterView = FooterVM;
		}

		private void OpenTextEditor()
		{
			TextEditorVM = new();
			TextEditor = TextEditorVM;
		}

	}
}
