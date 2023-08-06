using PhiloStory2.Core;
using PhiloStory2.MVVM.ViewModel;
using PhiloStory2.Properties;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace PhiloStory2.MVVM.View
{
	/// <summary>
	/// Interaction logic for SettingView.xaml
	/// </summary>
	public partial class SettingView : UserControl
	{
		private static List<string> names = new() { "Chủ nghĩa duy vật", "Chủ nghĩa duy tâm", "Chủ nghĩa hiện thực", "Chủ nghĩa duy danh", "Chủ nghĩa duy lý", "Chủ nghĩa kinh nghiệm",
		"Chủ nghĩa hoài nghi", "Chủ nghĩa lý tưởng", "Chủ nghĩa thực dụng", "Hiện tượng học, thuyên thích học", "Chủ nghĩa hiện sinh", "Triết học phân tích"};

        public SettingView()
		{
			InitializeComponent();
			string prefix = "Favorite";
			MenuItem mnp = (MenuItem)mnContentPref.FindName("mniPrefs");
			FontFamily philo = (FontFamily)FindResource("Philosopher");
			for (int i = 0; i<names.Count; i++)
			{
				CheckBox cb = new() {Name=prefix + (i+1).ToString(), Content = names[i], FontSize=15, FontFamily=philo, IsChecked = SettingViewModel.favorites[i] };
				cb.Checked += (sender, e) => FavoritieChanged(sender, e);
				cb.Unchecked += (sender, e) => FavoritieChanged(sender, e);
				mnp.Items.Add(cb);				
			}	
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

        private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri) { UseShellExecute = true }); ;
            e.Handled = true;
        }
        
		private void FavoritieChanged(object sender, RoutedEventArgs e)
		{
			if (sender is CheckBox cb)
			{
				string favoriteType = (sender as CheckBox).Name;
				Settings.Default[favoriteType] = cb.IsChecked;
				Settings.Default.Save();
			}
		}
	}
}
