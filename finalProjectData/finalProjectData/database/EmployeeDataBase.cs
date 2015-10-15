using System;
using SQLite.Net;
using Xamarin.Forms;
using System.Linq;
using System.Collections.Generic;
using GalaSoft.MvvmLight.Ioc;

namespace finalProjectData
{
	public class EmployeeDataBase
	{
		SQLiteConnection database;
		public EmployeeDataBase ()
		{
			database = DependencyService.Get<ISqlite> ().GetConnection ();


			init ();
			//TODO show IOC vs Dependency injection
			//			database = SimpleIoc.Default.GetInstance<ISqlite> ().GetConnection ();
			if (database.TableMappings.All(t => t.MappedType.Name != typeof(employee).Name)) {
				database.CreateTable<employee> ();
				database.Commit ();
			}
		}

		public List<employee> GetAll(){
			var items = database.Table<employee> ().ToList<employee>();

			return items;
		}

	public int InsertOrUpdateNote(employee employee){
			return database.Table<employee> ().Where (x => x.Name == employee.Name).Count () > 0 
				? database.Update (employee) : database.Insert (employee);
		}

		public employee GetNote(string key){
			return database.Table<employee> ().First (t => t.Name == key); 
		}


		public void init(){
			var db = database;
			db.CreateTable<employee>();

			var e1 = new employee () {
				Name = "Liu",
				AvailableTime = "30 mins",
				Position = "QUT"

			};

			db.Insert (e1);
			
	


		}

	}
}

