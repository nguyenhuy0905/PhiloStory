using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PhiloStory2.MVVM.Model
{
    class TextEditorModel
    {
        public TextEditorModel()
        {
            
        }
    }

    class FontFamilyItems : FontFamily
    {
        public FontFamily fonts = new();

        public FontFamilyItems() 
        {

        }
    }
}
