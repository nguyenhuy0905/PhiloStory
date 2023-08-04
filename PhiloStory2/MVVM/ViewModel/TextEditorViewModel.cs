using Microsoft.Win32;
using PhiloStory2.Core;
using PhiloStory2.MVVM.Model;
using PhiloStory2.MVVM.View;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.IO.Packaging;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;

namespace PhiloStory2.MVVM.ViewModel
{
	class TextEditorViewModel : ObservableObject
    {
        //public static object SelectedItem = new();

        public static ObservableCollection<FontFamilyItems> FontFam = new();
        
        public RelayCommand SaveTextCommand { get; set; }

        //hiện tại cái phần này đang bị lỗi.
        //public RelayCommand FontFamilyChangedCommand => new(execute => FontFamilyChanged());

        //public RelayCommand FontSizeChangedCommand => new(execute => FontSizeChanged());

        private readonly TextEditorView textEditorView = new();


        public TextEditorViewModel()
        {
            foreach (FontFamily f in Fonts.SystemFontFamilies)
            {
                FontFam.Add(new() { fonts = f });
            }
		}



        //private void FontFamilyChanged()
        //{
        //    if (textEditorView.cmbFonts.SelectedItem!=null)
        //    {
        //        textEditorView.rtbEditor.Selection.ApplyPropertyValue(Inline.FontFamilyProperty, SelectedItem);
        //    }
        //}

        //private void FontSizeChanged()
        //{
        //    if (textEditorView.cmbFontSize.SelectedItem != null)
        //    {
        //        textEditorView.rtbEditor.Selection.ApplyPropertyValue(Inline.FontSizeProperty, textEditorView.cmbFontSize.SelectedItem);
        //    }
        //}
    }
}
