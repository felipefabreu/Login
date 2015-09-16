using System;
using System.Collections.Generic;
using SQLite.Net.Attributes;
using SQLite.Net.Interop;
using System.Linq;

using Xamarin.Forms;

namespace LoginApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();






			/*this.create.Clicked += (object sender, EventArgs e) => {

				//ir para a tela de registro, ao invés de adicionar ao listview
				var usuario = new User(this.user.Text,this.password.Text);

				items = new string[] {usuario.Name, usuario.Password};
				list.ItemsSource = items;
			};*/

			/*
			this.login.Clicked += async (object sender, EventArgs e) => {
				//realizar verificação de login aqui

				if (user.Text=="adm" && password.Text=="123") {
					await DisplayAlert("Login","Logando","ok");
					await Navigation.PushAsync (new Loggedin ());
				}else{
					await DisplayAlert("Login","Usuario e/ou senha invalidos","ok");
				}
			};*/



			/*this.create.Clicked += async (object sender, EventArgs e) => {
				var user1 = new User(user.Text,password.Text);

				using (var dados = new AcessoDados ()) {
					dados.Insert(user1);
					//list.ItemsSource = dados.Listar ();
				}

				await Navigation.PushAsync(new Create());


			};*/
		}
		protected void CreateClick (object sender, EventArgs e){
			
			Navigation.PushAsync (new RegisterPage ());
			
		}

		protected void  LoginClick(object sender, EventArgs e){
				
				
			using (var dados = new AcessoDados ()) {
				User _user = dados.GetUser (this.user.Text);

			if (this.user.Text == "" || this.password.Text == "") {
				DisplayAlert("Login","Usuário e/ou senha incorretos","ok");
			}else if (_user.Name == this.user.Text && _user.Password == this.password.Text) {
					//DisplayAlert("Login","Sim","ok");
					Navigation.PushAsync (new Loggedin ());
				}else{
				DisplayAlert("Login","Usuário e/ou senha incorretos","ok");
				}
			}
		}
	}
}

