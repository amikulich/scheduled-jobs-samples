using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    public class ReportsController : ControllerBase
    {
        private readonly IReportDataSource _reportDataSource;

        public ReportsController(IReportDataSource reportDataSource)
        {
            _reportDataSource = reportDataSource;
        }

        [HttpGet]
        [Route("clients/{clientId}/daily-report")]
        public IActionResult Get(int clientId)
        {
            var result = _reportDataSource.GetByClient(clientId);

            return new JsonResult(result);
        }
    }
}
