using PhiloStory2.MVVM.Model;
using PhiloStory2.MVVM.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhiloStory2.MVVM.ViewModel
{
	internal class ArticleReaderViewModel
	{
		public ObservableCollection<Article> Articles = new()
			{
			//lưu ý đặt Name các bài viết khác nhau. 
				new() { Name = "MythOfSisyphus", Title = "The Myth of Sisyphus", Directory = basedir + "MythOfSisyphus.rtf" }, //<-- Articles[0] hoặc Articles.First(x => x.Name == "MythOfSisyphus")
				new() {Name = "MementoMori", Title = "Memento Mori", Directory = basedir + "MementoMori.rtf"},
				new() { Name = "Existentialism", Title = "Khái quát - Chủ nghĩa Hiện sinh", Directory = basedir + "existent.rtf" },
				new() { Name = "Ethics", Title="Khái quát - Luân lí học", Directory = basedir + "ethicbasics.rtf" }
			};

		private static string basedir = Environment.CurrentDirectory.Replace(@"bin\Debug\net7.0-windows", @"Assets\\Articles\\");

		public ArticleReaderViewModel(string ArticleName)
        {
			Article target = Articles.First(article => article.Name == ArticleName);
			string Title = target.Title;
			string Directory = target.Directory;

			ArticleReaderView reader = new(Title, Directory);

		}
    }
}
