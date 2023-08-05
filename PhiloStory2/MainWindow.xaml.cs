using PhiloStory2.Core;
using PhiloStory2.MVVM.ViewModel;
using System;
using System.Configuration;
using System.Windows;
using System.Windows.Input;
using PhiloStory2.Properties;

namespace PhiloStory2
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private MainViewModel viewModel = new();
		
		public MainWindow()
		{
			InitializeComponent();
			bool dtVal = (bool)Settings.Default["IsDarkTheme"];

			if (dtVal)
			{
				SwitchTheme.ChangeTheme(new Uri("Theme/DarkTheme.xaml", UriKind.Relative));
				return;
			}
			SwitchTheme.ChangeTheme(new Uri("Theme/NeutralTheme.xaml", UriKind.Relative));
		}

		private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			DragMove();
		}

		private void btnMinimize_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.MainWindow.WindowState = WindowState.Minimized;
		}

		private void btnMaximize_Click(object sender, RoutedEventArgs e)
		{
			if(Application.Current.MainWindow.WindowState == WindowState.Maximized)
			{
				Application.Current.MainWindow.WindowState = WindowState.Normal; return;
			}
			Application.Current.MainWindow.WindowState = WindowState.Maximized;
		}

		private void btnClose_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Shutdown();
		}

		private void NavButton_MouseEnter(object sender, MouseEventArgs e)
		{
			SoundEffect.PlayMouseHover();
        }
		
	}
}
