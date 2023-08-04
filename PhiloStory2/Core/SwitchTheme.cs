using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PhiloStory2.Core
{
    class SwitchTheme
    {
        public static void ChangeTheme(Uri theme)
        {
            ResourceDictionary Theme = new ResourceDictionary() { Source = theme };
            App.Current.Resources.MergedDictionaries[0].Clear();
            App.Current.Resources.MergedDictionaries.Add(Theme);

        }
    }
}
