using PhiloStory2.Core;
using PhiloStory2.MVVM.ViewModel;
using System.Media;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace PhiloStory2.MVVM.View
{
	/// <summary>
	/// Interaction logic for LibraryView.xaml
	/// </summary>
	public partial class LibraryView : UserControl
	{


		public LibraryView()
		{
			InitializeComponent();
		}

		private void Button_PreviewMouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			if (sender is Button btn)
			{
				ArticleReaderViewModel ArticleReaderVM = new((string)btn.Tag);
			}
		}

		private void ScrollViewer_PreviewMouseWheel(object sender, System.Windows.Input.MouseWheelEventArgs e)
		{
			if (sender is ScrollViewer && !e.Handled)
			{
				e.Handled = true;
				var eventArg = new MouseWheelEventArgs(e.MouseDevice, e.Timestamp, e.Delta);

				eventArg.RoutedEvent = MouseWheelEvent;

				eventArg.Source = sender;

				var parent = ((Control)sender).Parent as UIElement;

				parent.RaiseEvent(eventArg);
			}
		}

		private void Button_MouseEnter(object sender, MouseEventArgs e)
		{
			SoundEffect.PlayMouseHover();
		}
	}
}
