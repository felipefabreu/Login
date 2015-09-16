using System;
using System.Linq;
using Xamarin.Forms;
using System.Collections.Generic;

namespace LoginApp
{
	public class AcessoDados : IDisposable
	{

		private SQLite.Net.SQLiteConnection _conexao;

		public AcessoDados(){
			var config = DependencyService.Get<iConfig> ();
			_conexao = new SQLite.Net.SQLiteConnection (config.Plataforma, System.IO.Path.Combine (config.DiretorioDB, "bancodados.db3"));

			_conexao.CreateTable<User> ();

		}

		public void Insert(User user){
			_conexao.Insert (user);
		}

		public List<User> Listar(){
			return _conexao.Table<User> ().OrderBy (c => c.Name).ToList();
		}

		public User GetUser(string nome){
			/*var usuario = from s in _conexao.Table<User> ()
			               where s.Name.Equals (nome)
			               select s;*/
			//SQLite.Net.TableQuery<User> usuario2 = new SQLite.Net.TableQuery<User>(

			return _conexao.Table<User> ().FirstOrDefault (name => name.Name == nome);

		}
		/*
			var apple = from s in db.Table<User>()
					where s.Symbol.StartsWith ("A")
				select s;
			Console.WriteLine ("-> " + apple.FirstOrDefault ().Symbol);
		*/

		public void Dispose ()
		{
			_conexao.Dispose ();
		}
	
		
	}
}

