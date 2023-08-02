using PhiloStory2.Core;
using System;
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
    }
}
