using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LoginApp
{
	public partial class Loggedin : ContentPage
	{
		public Loggedin ()
		{
			InitializeComponent ();
			this.back.Clicked += (object sender, EventArgs e) => {

				Navigation.PopAsync();
			};
		}
	}
}

