using System;
using SQLite.Net;

namespace finalProjectData
{
	public interface ISqlite
	{
		SQLiteConnection GetConnection();
	}
}

