namespace CapitolTrackMobile.Models
{
	public class ReportList
	{
		public string ReportCategory { get; set; }
		public string ReportName { get; set; }
		public string ReportDescription { get; set; }
		public string ReportLastUpdateDate { get; set; }

		public string NameSort => ReportCategory[0].ToString();
	}
}

