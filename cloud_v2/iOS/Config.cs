using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Foundation;
using UIKit;
using SQLite.Net.Interop;
using Xamarin.Forms;


[assembly: Dependency(typeof(cloud.iOS.Config))]


namespace cloud.iOS
{
	class Config :IConfig
	{
		private string directDB;

		private ISQLitePlatform Platform;

			private string DirectDB
			{
				get 
				{
					if (string.IsNullOrEmpty (directorDB)) 
					{
					var direct = System.Environment.GetFolderPath (Environment.SpecialFolder.Personal);
							directorDB = System.IO.Path.Combine(direct, "..", "Library");
					
					}
							return directDB;

				}
			}

		public ISQLitePlaform Platform
		{
			get
			{
				if (platform == null)
				{
					platform = new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS();
				}	
			}	return platform;
			
		}
	}
}

