using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PhiloStory2.MVVM.View
{
	/// <summary>
	/// Interaction logic for ArticleReaderView.xaml
	/// </summary>
	public partial class ArticleReaderView : Window
	{
		public ArticleReaderView(string Title, string ArticleDirectory)
		{			
			InitializeComponent();
			this.Title = Title;
			FileStream fs = new(ArticleDirectory, FileMode.Open);
			TextRange range = new(txtArticleHolder.Document.ContentStart, txtArticleHolder.Document.ContentEnd);	
			range.Load(fs, DataFormats.Rtf);
			range.ApplyPropertyValue(Inline.ForegroundProperty, this.txtArticleHolder.Foreground);
			range.ApplyPropertyValue(Inline.FontFamilyProperty, this.txtArticleHolder.FontFamily);
			fs.Close();
			this.Show();

			this.Topmost = true;
		}
	}
}
