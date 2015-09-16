using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LoginApp
{
	public partial class Create : ContentPage
	{
		public Create ()
		{
			InitializeComponent ();

			using (var dados = new AcessoDados ()) {
				
				this.lista.ItemsSource = dados.Listar ();
			}


		}
	}
}

