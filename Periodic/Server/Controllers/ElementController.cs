using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Periodic.Shared.Models;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using System.Text;

namespace Periodic.Server.Controllers
{
    
    [ApiController]
    public class ElementController : ControllerBase
    {
        [Route("api/elements")]
        [HttpGet]
        public ActionResult<List<string[]>> GetElements()
        {
            var allElements = new AllElements().allElementsListed;
            byte[] buffer = Encoding.UTF8.GetBytes(allElements);
            MemoryStream stream = new MemoryStream(buffer);
            using var reader = new StreamReader(stream);
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ";",
            };
            using var csv = new CsvReader(reader, config);
            return Ok(csv.GetRecords<Element>().ToArray());
        }
    }
}

