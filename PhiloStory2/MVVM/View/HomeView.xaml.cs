using PhiloStory2.Core;
using System;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace PhiloStory2.MVVM.View
{
	/// <summary>
	/// Interaction logic for HomeView.xaml
	/// </summary>


	public partial class HomeView : UserControl
	{
		protected MediaPlayer Player = new MediaPlayer();
		string basedir = System.AppDomain.CurrentDomain.BaseDirectory;

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

			basedir = basedir.Replace(@"bin\Debug\net7.0-windows", "");
			var path = System.IO.Path.GetFullPath($"{basedir}/Assets/Sounds/mousehover.wav");
			
			Player.Open(new Uri(path, UriKind.RelativeOrAbsolute));
			Player.Play();			
		}
		
	}
}
