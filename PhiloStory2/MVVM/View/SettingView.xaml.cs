using PhiloStory2.Core;
using PhiloStory2.Properties;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace PhiloStory2.MVVM.View
{
	/// <summary>
	/// Interaction logic for SettingView.xaml
	/// </summary>
	public partial class SettingView : UserControl
	{
        public SettingView()
		{
			InitializeComponent();
			
		}

		private void SettingButton_MouseEnter(object sender, RoutedEventArgs e)
		{
			SoundEffect.PlayMouseHover();
        }

        private void NeutralMode(object sender, RoutedEventArgs e)
        {
			SwitchTheme.ChangeTheme(new Uri("Theme/NeutralTheme.xaml", UriKind.Relative));
            Settings.Default["IsDarkTheme"] = false;
            Settings.Default.Save();
        }

        private void DarkMode(object sender, RoutedEventArgs e)
        {
            SwitchTheme.ChangeTheme(new Uri("Theme/DarkTheme.xaml", UriKind.Relative));
			Settings.Default["IsDarkTheme"] = true;
			Settings.Default.Save();
		}

        private void hyperAboutUs_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri) { UseShellExecute = true }); ;
            e.Handled = true;
        }

        private void hyperContact_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri) { UseShellExecute = true }); ;
            e.Handled = true;
        }

        private void hyperCourse_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri) { UseShellExecute = true }); ;
            e.Handled = true;
        }

        private void hyperFAQ_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri) { UseShellExecute = true }); ;
            e.Handled = true;
        }

        private void FavoritieCheck(object sender, RoutedEventArgs e)
        {
        }

        private void FavoritieUnCheck(object sender, RoutedEventArgs e)
        {
        }
    }
}
