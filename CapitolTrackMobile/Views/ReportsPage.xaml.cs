using Xamarin.Forms;
using Reports.ViewModels;
using CapitolTrackMobile.Models;
using System.Collections.Generic;
using System.Collections;
using System.Collections.ObjectModel;
using System.Linq;

namespace CapitolTrackMobile.Views
{
	public partial class ReportsPage : ContentPage
	{
		public ReportsPage()
		{
			BindingContext = new ReportsViewModel();
		}

		void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
		=> ((ListView)sender).SelectedItem = null;

		void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var report = ((ListView)sender).SelectedItem as ReportsPage;
			if (report == null)
				return;
		}
	}
}
