using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodiApp.Data;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace FoodiAppTest
{
	public abstract class MockDB : IDisposable
	{
		private readonly SqliteConnection _connection;

		protected readonly FoodieDBContext _db;
		public MockDB()
		{
			_connection = new SqliteConnection();
			_connection.Open();
			_db = new FoodieDBContext(
				new DbContextOptionsBuilder<FoodieDBContext>()
				.UseSqlite(_connection).Options);
			_db.Database.EnsureCreated();
		}
		public void Dispose()
		{
			_db?.Dispose();
			_connection?.Dispose();
		}

	}
}
