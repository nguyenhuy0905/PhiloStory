using PhiloStory2.Core;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace PhiloStory2.MVVM.View
{
	/// <summary>
	/// Interaction logic for HomeView.xaml
	/// </summary>


	public partial class HomeView : UserControl
	{
		public HomeView()
		{
			InitializeComponent();
			
		}

		private void ScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
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

		private void ContentControl_MouseEnter(object sender, MouseEventArgs e)
		{
			SoundEffect.PlayMouseHover();
		}
		
	}
}
