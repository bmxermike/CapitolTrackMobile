using Xamarin.Forms;
using System.Collections.Generic;
using System.Collections;

namespace CapitolTrackMobile
{
	public partial class ReportsPage : ContentPage
	{
		public ReportsPage()
		{
			InitializeComponent();
			listView.ItemsSource = new List<ReportCategoryList>(){
				new ReportCategoryList() { ReportCategoryTitle = "Title Here"},
			};

		}
	}

	public class ReportCategoryList
	{
		public string ReportCategoryTitle { get; set; }

	}
}

