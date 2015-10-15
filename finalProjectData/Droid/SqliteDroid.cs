using System;
using System.IO;
using finalProject;
using finalProject.Droid;
using finalProjectData;
using Xamarin.Forms;
using SQLite.Net;



//TODO show IOC vs Dependency Injection
[assembly: Dependency (typeof (SqliteDroid))]
namespace finalProject
{
	public class SqliteDroid : ISqlite
	{
		public SqliteDroid(){
		}
		#region ISqlite implementation
		public SQLiteConnection GetConnection ()
		{
			const string sqliteFilename = "database.db3";
			var documentsPath = Environment.GetFolderPath (Environment.SpecialFolder.Personal);
			var path = Path.Combine (documentsPath, sqliteFilename);
			var plat = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
			//Create the connection
			var conn = new SQLiteConnection(plat,path);
			return conn;
		}
		#endregion
	}
}