using System;
using SQLite.Net.Interop;


namespace LoginApp
{
	public interface iConfig
	{
		string DiretorioDB { get; }
		ISQLitePlatform Plataforma { get; }
	}
}

