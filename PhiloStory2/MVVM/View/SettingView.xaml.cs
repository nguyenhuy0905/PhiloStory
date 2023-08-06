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

        private void FavoritieCheck1(object sender, RoutedEventArgs e)
        {
            Settings.Default["Favorite1"] = true;
            Settings.Default.Save();
        }

        private void FavoritieUnCheck1(object sender, RoutedEventArgs e)
        {
            Settings.Default["Favorite1"] = false;
            Settings.Default.Save();
        }

        private void FavoritieCheck2(object sender, RoutedEventArgs e)
        {
            Settings.Default["Favorite2"] = true;
            Settings.Default.Save();
        }

        private void FavoritieUnCheck2(object sender, RoutedEventArgs e)
        {
            Settings.Default["Favorite2"] = false;
            Settings.Default.Save();
        }

        private void FavoritieCheck3(object sender, RoutedEventArgs e)
        {
            Settings.Default["Favorite3"] = true;
            Settings.Default.Save();
        }

        private void FavoritieCheck4(object sender, RoutedEventArgs e)
        {
            Settings.Default["Favorite4"] = true;
            Settings.Default.Save();
        }

        private void FavoritieCheck5(object sender, RoutedEventArgs e)
        {
            Settings.Default["Favorite5"] = true;
            Settings.Default.Save();
        }

        private void FavoritieCheck6(object sender, RoutedEventArgs e)
        {
            Settings.Default["Favorite6"] = true;
            Settings.Default.Save();
        }

        private void FavoritieCheck7(object sender, RoutedEventArgs e)
        {
            Settings.Default["Favorite7"] = true;
            Settings.Default.Save();
        }

        private void FavoritieCheck8(object sender, RoutedEventArgs e)
        {
            Settings.Default["Favorite8"] = true;
            Settings.Default.Save();
        }

        private void FavoritieCheck9(object sender, RoutedEventArgs e)
        {
            Settings.Default["Favorite9"] = true;
            Settings.Default.Save();
        }

        private void FavoritieCheck10(object sender, RoutedEventArgs e)
        {
            Settings.Default["Favorite10"] = true;
            Settings.Default.Save();
        }

        private void FavoritieCheck11(object sender, RoutedEventArgs e)
        {
            Settings.Default["Favorite11"] = true;
            Settings.Default.Save();
        }

        private void FavoritieCheck12(object sender, RoutedEventArgs e)
        {
            Settings.Default["Favorite12"] = true;
            Settings.Default.Save();
        }

        private void FavoritieUnCheck3(object sender, RoutedEventArgs e)
        {
            Settings.Default["Favorite3"] = false;
            Settings.Default.Save();
        }

        private void FavoritieUnCheck4(object sender, RoutedEventArgs e)
        {
            Settings.Default["Favorite4"] = false;
            Settings.Default.Save();
        }

        private void FavoritieUnCheck5(object sender, RoutedEventArgs e)
        {
            Settings.Default["Favorite5"] = false;
            Settings.Default.Save();
        }

        private void FavoritieUnCheck6(object sender, RoutedEventArgs e)
        {
            Settings.Default["Favorite6"] = false;
            Settings.Default.Save();
        }

        private void FavoritieUnCheck7(object sender, RoutedEventArgs e)
        {
            Settings.Default["Favorite7"] = false;
            Settings.Default.Save();
        }

        private void FavoritieUnCheck8(object sender, RoutedEventArgs e)
        {
            Settings.Default["Favorite8"] = false;
            Settings.Default.Save();
        }

        private void FavoritieUnCheck9(object sender, RoutedEventArgs e)
        {
            Settings.Default["Favorite9"] = false;
            Settings.Default.Save();
        }

        private void FavoritieUnCheck10(object sender, RoutedEventArgs e)
        {
            Settings.Default["Favorite10"] = false;
            Settings.Default.Save();
        }

        private void FavoritieUnCheck11(object sender, RoutedEventArgs e)
        {
            Settings.Default["Favorite11"] = false;
            Settings.Default.Save();
        }

        private void FavoritieUnCheck12(object sender, RoutedEventArgs e)
        {
            Settings.Default["Favorite12"] = false;
            Settings.Default.Save();
        }
    }
}
