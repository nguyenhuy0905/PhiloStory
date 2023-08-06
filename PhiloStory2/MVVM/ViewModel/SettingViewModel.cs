using PhiloStory2.Core;
using PhiloStory2.Properties;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace PhiloStory2.MVVM.ViewModel
{
	internal class SettingViewModel : ObservableObject
	{
		public FooterViewModel FooterVM { get; set; }

		

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
		}
		public bool Favorite1 { get; set; } = (bool)Settings.Default["Favorite1"];
	        public bool Favorite2 { get; set; } = (bool)Settings.Default["Favorite2"];
	        public bool Favorite3 { get; set; } = (bool)Settings.Default["Favorite3"];
	        public bool Favorite4 { get; set; } = (bool)Settings.Default["Favorite4"];
	        public bool Favorite5 { get; set; } = (bool)Settings.Default["Favorite5"];
	        public bool Favorite6 { get; set; } = (bool)Settings.Default["Favorite6"];
	        public bool Favorite7 { get; set; } = (bool)Settings.Default["Favorite7"];
	        public bool Favorite8 { get; set; } = (bool)Settings.Default["Favorite8"];
	        public bool Favorite9 { get; set; } = (bool)Settings.Default["Favorite9"];
	        public bool Favorite10 { get; set; } = (bool)Settings.Default["Favorite10"];
	        public bool Favorite11 { get; set; } = (bool)Settings.Default["Favorite11"];
	        public bool Favorite12 { get; set; } = (bool)Settings.Default["Favorite12"];
	        public bool Favorite13 { get; set; } = (bool)Settings.Default["Favorite13"];
    	}
}
