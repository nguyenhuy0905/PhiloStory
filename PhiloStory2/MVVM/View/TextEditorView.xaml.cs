using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace PhiloStory2.MVVM.View
{
	/// <summary>
	/// Interaction logic for TextEditorView.xaml
	/// </summary>
	public partial class TextEditorView : UserControl
	{
		public TextEditorView()
		{
			InitializeComponent();
			cmbFonts.ItemsSource = Fonts.SystemFontFamilies.OrderBy(f => f.Source);
			cmbFontSize.ItemsSource = new List<double>() {6, 8, 10, 12, 14, 16, 18, 20, 24, 28, 30, 36, 40, 48, 54, 64, 72, 80};
			
		}
	
		private void ScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
		{
			if (sender is ScrollViewer && !e.Handled)
			{
				e.Handled = true;
				var eventArg = new MouseWheelEventArgs(e.MouseDevice, e.Timestamp, e.Delta)
				{
					RoutedEvent = MouseWheelEvent,

					Source = sender
				};

				var parent = ((Control)sender).Parent as UIElement;

				RaiseEvent(eventArg);
			}
		}
		//cách này không tốt, nếu được nên đẩy hết command này sang ViewModel. 
		private void cmbFonts_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{

			if (cmbFonts.SelectedItem != null)
			{
				FontFamily selectedFont = cmbFonts.SelectedItem as FontFamily;
				rtbEditor.Selection.ApplyPropertyValue(Inline.FontFamilyProperty, selectedFont);
			}
		}

		private void cmbFontSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (cmbFontSize.SelectedItem != null)
			{
				rtbEditor.Selection.ApplyPropertyValue(Inline.FontSizeProperty, cmbFontSize.SelectedItem);
				
			}			
		}

		private void btnImage_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			OpenFileDialog ofd = new();
			ofd.InitialDirectory = Environment.CurrentDirectory.Replace(@"bin\Debug\net7.0-windows", @"Assets\UserWrittenFiles");
			ofd.Multiselect = false;
			ofd.Filter = "Images | *.png; *.jpg; *.jpeg; *.bmp";
			string directory = "";
			if (ofd.ShowDialog() == true) { 
				directory = System.IO.Path.GetFullPath(ofd.FileName);
				Clipboard.SetImage(new BitmapImage(new Uri(directory, UriKind.Absolute)));
				rtbEditor.Paste();
			}
			
		}

		private void OpenFile_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.InitialDirectory = Environment.CurrentDirectory.Replace(@"bin\Debug\net7.0-windows", @"Assets\UserWrittenFiles");
			dlg.Filter = "Rich Text Format (*.rtf)|*.rtf|All files (*.*)|*.*";
			if (dlg.ShowDialog() == true)
			{
				FileStream fileStream = new FileStream(dlg.FileName, FileMode.Open);
				TextRange range = new TextRange(rtbEditor.Document.ContentStart, rtbEditor.Document.ContentEnd);
				range.Load(fileStream, DataFormats.Rtf);
			}
		}

		private void SaveFile_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			SaveFileDialog dlg = new SaveFileDialog();
			dlg.InitialDirectory = Environment.CurrentDirectory.Replace(@"bin\Debug\net7.0-windows", @"Assets\UserWrittenFiles");
			dlg.Filter = "Rich Text Format (*.rtf)|*.rtf|All files (*.*)|*.*";
			if (dlg.ShowDialog() == true)
			{
				FileStream fileStream = new FileStream(dlg.FileName, FileMode.Create);
				TextRange range = new TextRange(rtbEditor.Document.ContentStart, rtbEditor.Document.ContentEnd);
				range.Save(fileStream, DataFormats.Rtf);
			}
		}

		private void rtbEditor_SelectionChanged(object sender, RoutedEventArgs e)
		{
			cmbFonts.SelectedItem = rtbEditor.Selection.GetPropertyValue(Inline.FontFamilyProperty);
			cmbFontSize.SelectedItem = rtbEditor.Selection.GetPropertyValue(Inline.FontSizeProperty);
			SolidColorBrush brush = new();
			try
			{
				brush = (SolidColorBrush)rtbEditor.Selection.GetPropertyValue(Inline.ForegroundProperty);
				Color selectedItemColor = Color.FromArgb(brush.Color.A, brush.Color.R, brush.Color.G, brush.Color.B);
				btnColor.SelectedColor = selectedItemColor;
			} catch (Exception)
			{

			}
			
			
		}

		private void btnColor_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
		{
			if (btnColor.SelectedColor != null && rtbEditor != null) 
			{
				rtbEditor.Selection.ApplyPropertyValue(Inline.ForegroundProperty, new BrushConverter().ConvertFrom(btnColor.SelectedColor.ToString()) as SolidColorBrush);
			} 
		}
	}
}
