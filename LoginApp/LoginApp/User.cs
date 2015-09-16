using System;
using SQLite.Net.Attributes;


namespace LoginApp
{
	public class User
	{
		
		[PrimaryKey, AutoIncrement]
		public int Id {
			get;
			set;
		}

		public string Name {
			get;
			set;
		}

		public string Password {
			get;
			set;
		}


		public override string ToString ()
		{
			return string.Format ("[User: Name={0}, Password={1}]", Name, Password);
		}

	}
}

