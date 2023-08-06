using PhiloStory2.Core;
using PhiloStory2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace PhiloStory2.MVVM.ViewModel
{
	internal class SettingViewModel : ObservableObject
	{
		public FooterViewModel FooterVM { get; set; }

		public static List<bool> favorites = new();

		public static readonly int FavoriteContentChoices = 13;

		public static readonly string prefix = "Favorite";

		private string username = (string)Settings.Default["Username"];

		public string Username
		{
			get { return username; }
			set { username = value; OnPropertyChanged(); }
		}


		private object footerView;

		public object FooterView
		{
			get { return footerView; }
			set { footerView = value;
				OnPropertyChanged();
			}
		}

		public SettingViewModel() {
		    FooterVM = new FooterViewModel();
			FooterView = FooterVM;

			string fullname;

			for (int i = 1; i<= FavoriteContentChoices; i++)
			{
				fullname = prefix + i.ToString();
				favorites.Add((bool)Settings.Default[fullname]);
			}
		}

		
    	}
}
