using System;
using System.ComponentModel;
using System.Collections.ObjectModel;


using Xamarin.Forms;

namespace CapitolTrackMobile
{
	public partial class ReportCategoryPage : ContentPage
	{

		public ObservableCollection<ReportListViewModel> reports { get; set; }
		public ReportCategoryPage()
		{
			reports = new ObservableCollection<ReportListViewModel>();
			InitializeComponent();
			reportList.ItemsSource = reports;
			reports.Add (new ReportListViewModel { ReportName = "All Bills", ReportDescricption = "Descricption will go here", ReportLastEditDate = "MM/DD/YYYY" });
			reports.Add(new ReportListViewModel { ReportName = "All Keyword Search Report", ReportDescricption = "Descricption", ReportLastEditDate = "MM/DD/YYYY" });
			reports.Add(new ReportListViewModel { ReportName = "Daily Report", ReportDescricption = "Descricption", ReportLastEditDate = "MM/DD/YYYY" });
			reports.Add(new ReportListViewModel { ReportName = "Todays New Bills", ReportDescricption = "Descricption", ReportLastEditDate = "MM/DD/YYYY" });
			reports.Add(new ReportListViewModel { ReportName = "Untracked Water Keyword Search", ReportDescricption = "Descricption", ReportLastEditDate = "MM/DD/YYYY" });
			reports.Add(new ReportListViewModel { ReportName = "Need Attention", ReportDescricption = "Descricption", ReportLastEditDate = "MM/DD/YYYY" });
			reports.Add(new ReportListViewModel { ReportName = "Bill Watch List", ReportDescricption = "Descricption", ReportLastEditDate = "MM/DD/YYYY" });
		}
	}
}

	