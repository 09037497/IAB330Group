using System;
using SQLite.Net;
using Xamarin.Forms;
using System.Linq;
using System.Collections.Generic;
using GalaSoft.MvvmLight.Ioc;

namespace employee.Data
{
	public class EmployeeDataBase
	{
		SQLiteConnection database;
		public EmployeeDataBase ()
		{
			database = DependencyService.Get<ISqlite> ().GetConnection ();
			//TODO show IOC vs Dependency injection
			//			database = SimpleIoc.Default.GetInstance<ISqlite> ().GetConnection ();
			if (database.TableMappings.All(t => t.MappedType.Name != typeof(Employee).Name)) {
				database.CreateTable<Employee> ();
				database.Commit ();
			}
		}

		public List<Note> GetAll(){
			var items = database.Table<Employee> ().ToList<Employeee>();

			return items;
		}

		public int InsertOrUpdateNote(Employee employee){
			return database.Table<Employee> ().Where (x => x.name == employee.name).Count () > 0 
				? database.Update (employee) : database.Insert (employee);
		}

		public Employee GetNote(string key){
			return database.Table<Employee> ().First (t => t.name == key); 
		}

	}
}

