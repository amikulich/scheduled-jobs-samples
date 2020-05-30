using System;
using System.Threading;

namespace Api
{
    public class ReportDataSource : IReportDataSource
    {
        public ReportData GetByClient(int clientId)
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));

            return new ReportData()
            {
                ClientId = clientId,
                Info = $"report for {clientId}"
            };
        }
    }

    public interface IReportDataSource
    {
        ReportData GetByClient(int clientId);
    }

    public class ReportData
    {
        public int ClientId { get; set; }

        public string Info { get; set; }
    }
}
