using System;
using SQLite.Net.Attributes;

namespace finalProjectData
{
	public class employee
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		public string Name { get; set; }
		public string Position { get; set; }
		public string AvailableTime { get; set; }

		public employee(){
		}
		/// <summary>
		/// Initializes a new instance of the <see cref="NoteTaker1.Notes"/> class.
		/// </summary>
		/// <param name="titleText">Title text.</param>
		/// <param name="timeStamp">Time stamp.</param>
		/// <param name="actionRequiredFlag">Action required flag.</param>
		public employee (string name, string position, string availableTime)
		{
			this.Name = name;
			Position = position;
			AvailableTime = availableTime;

	}
	}
}
