using System.Diagnostics;
using System.Runtime.Versioning;
using System.Threading;
using System.Windows.Controls;

namespace PhiloStory2.MVVM.View
{
	/// <summary>
	/// Interaction logic for FooterView.xaml
	/// </summary>
	public partial class FooterView : UserControl
    {
        public FooterView()
        {
            InitializeComponent();
        }

		private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
		{
			Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri) { UseShellExecute = true }); ;
			e.Handled = true;
		}
	}
}
