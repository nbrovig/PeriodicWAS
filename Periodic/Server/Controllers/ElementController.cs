using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Periodic.Shared.Models;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

namespace Periodic.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElementController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Element>>> GetElements()
        {
            var file = "..\\Shared\\Files\\Elements.csv";
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ";",
            };
            using var reader = new StreamReader(file);
            using var csv = new CsvReader(reader, config);
            return Ok(csv.GetRecords<Element>().ToArray());
        }
    }
}

