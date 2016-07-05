using CapitolTrackMobile.Helpers;
using CapitolTrackMobile.Models;
using System.Collections.ObjectModel;
using CapitolTrackMobile;


namespace Reports.ViewModels
{
	public class ReportsViewModel
	{
		public ObservableCollection<ReportList> Reports { get; set; }
		public ObservableCollection<Grouping<string, ReportList>> ReportsGrouped { get; set; }

		public ReportsViewModel()
		{
			Reports = ReportHelper.Reports;
			ReportsGrouped = ReportHelper.ReportsGrouped;
		}

		public int ReportCount => Reports.Count;
	}
}