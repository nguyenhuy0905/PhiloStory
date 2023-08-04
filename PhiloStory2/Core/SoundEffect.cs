using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PhiloStory2.Core
{
	public class SoundEffect
	{
		private static readonly MediaPlayer _player = new();
		static string basedir = System.AppDomain.CurrentDomain.BaseDirectory;
		

		public static void PlayMouseHover() 
		{
			basedir = basedir.Replace(@"bin\Debug\net7.0-windows", "/Assets/Sounds/mousehover.wav");
			var path = System.IO.Path.GetFullPath(basedir);

			_player.Open(new Uri(path, UriKind.RelativeOrAbsolute));
			_player.Play();
		}		
	}
}
