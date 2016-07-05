using Xamarin.Forms;
using System.Collections.Generic;
using System.Collections;

namespace CapitolTrackMobile
{
	public partial class ReportCategoryPage : ContentPage
	{
		public ReportCategoryPage()
		{
			InitializeComponent();
			listView.ItemsSource = new List<ReportCategoryPageList>(){
				new ReportCategoryPageList() { ReportName = "All", ReportDescricption = "Descricption will go here", ReportLastEditDate = "MM/DD/YYYY"},
			};

		}
	}

	public class ReportCategoryPageList
	{
		public string ReportName { get; set; }
		public string ReportDescricption { get; set; }
		public string ReportLastEditDate { get; set; }

	}
}

