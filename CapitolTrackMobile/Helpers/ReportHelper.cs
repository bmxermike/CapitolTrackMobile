using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CapitolTrackMobile.Models;
using CapitolTrackMobile.Helpers;
using System.Linq;

namespace CapitolTrackMobile
{
	public static class ReportHelper
	{
		private static Random random;

		public static ReportList GetRandomReport()
		{
			return Reports[random.Next(0, Reports.Count)];
		}

		public static ObservableCollection<Grouping<string, ReportList>> ReportsGrouped { get; set; }

		public static ObservableCollection<ReportList> Reports { get; set; }

		static ReportHelper()
		{
			random = new Random();
			Reports = new ObservableCollection<Models.ReportList>();

			Reports.Add(new ReportList
			{
				ReportCategory = "Report Category 1",
				ReportName = "Report Name 1",
				ReportDescription = "Here is a report descricption",
				ReportLastUpdateDate = "MM/DD/YYYY"
			});	

			Reports.Add(new ReportList
			{
				ReportCategory = "Report Category 2",
				ReportName = "Report Name 2",
				ReportDescription = "Here is a report descricption",
				ReportLastUpdateDate = "MM/DD/YYYY"
			});

			Reports.Add(new ReportList
			{
				ReportCategory = "Report Category 3",
				ReportName = "Report Name 3",
				ReportDescription = "Here is a report descricption",
				ReportLastUpdateDate = "MM/DD/YYYY"
			});

			Reports.Add(new ReportList
			{
				ReportCategory = "Report Category 4",
				ReportName = "Report Name 3",
				ReportDescription = "Here is a report descricption",
				ReportLastUpdateDate = "MM/DD/YYYY"
			});

			Reports.Add(new ReportList
			{
				ReportCategory = "Report Category 4",
				ReportName = "Report Name 3",
				ReportDescription = "Here is a report descricption",
				ReportLastUpdateDate = "MM/DD/YYYY"
			});

			var sorted = from Reports in Reports
						 orderby Reports.ReportCategory
						 group Reports by Reports.NameSort into reportGroup
                         select new Grouping<string, ReportList>(reportGroup.Key, reportGroup);

			ReportsGrouped = new ObservableCollection<Grouping<string, ReportList>>(sorted);

		}	
	}
}

