using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LoginApp
{
	public partial class RegisterPage : ContentPage
	{
		public RegisterPage ()
		{
			InitializeComponent ();

		}

		protected void CreateClick (object sender, EventArgs e){

			var user1 = new User {
				Name = this.user.Text,	
				Password = this.password.Text
			};

			using (var dados = new AcessoDados ()) {
				dados.Insert(user1);
				DisplayAlert("Login","Novo usuário registrado com sucesso","ok");
				Navigation.PopAsync ();
			}
		}
	}
}

