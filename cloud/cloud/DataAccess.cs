using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net;
using Xamarin.Forms;
using System.IO;

namespace cloud
{
	public class DataAccess : IDisposable
	{
		private SQLiteConnection connection;

		public DataAccess()
		{
			var config = DependencyService.Get<IConfig> ();
			//part3/8
			connection = new SQLiteConnection (config.Platform, Path.Combine (config.DirectDB, "Employ.db3"));
			//connection = new SQLiteConnection (config.Platform, System.IO.Path.Combine (config.DirectDB, "Employ.db3"));
			connection.CreateTable<Employ> ();
		}

		public void InsertEmploy(Employ employ)
		{
			connection.Insert (employ);
		}

		public void UpdateEmploy(Employ employ)
		{
			connection.Update (employ);
		}

		public void DeleteEmploy(Employ employ)
		{
			connection.Delete(employ);
		}

		public void GetEmploy(int IDEmploy)
		{
			return connection.Table<Employ>().FirstOrDefault(c => c.IDEmploy == IDEmploy);
		}

		public List<Employ> GetEmploy()
		{
			return connection.Table<Employ> ().OrderBy (c => c.Apellidos).ToList ();
			//return connection.Table<Employ> ().ToList ();
		}

		public void Dispose()
		{
			//throw new NotImplementedException ();
			connection.Dispose();
		}
	}
}

