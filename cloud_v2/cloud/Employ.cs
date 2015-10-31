using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;


namespace cloud
{
	public class Employ
	{	
		[PrimaryKey, AutoIncrement]
		public int IDEmploy { get; set; }
		public string Numbers { get; set; }

		public override string ToString ()
		{
			
			return string.Format("{0} {1} {2} {3} {4} ",  IDEmploy, Numbers);

		}


	}
	
}

