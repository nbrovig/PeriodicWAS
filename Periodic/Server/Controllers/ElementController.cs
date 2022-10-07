using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Periodic.Shared.Models;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;


namespace Periodic.Server.Controllers
{
    
    [ApiController]
    public class ElementController : ControllerBase
    {
        [Route("api/element")]
        [HttpGet]
        public ActionResult<List<Element>> GetElements()
        {
            //var file = "..\\Shared\\Files\\Elements.csv";
            var file = "Elements.csv";
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ";",
            };
            using var reader = new StreamReader(file);
            using var csv = new CsvReader(reader, config);
            return Ok(csv.GetRecords<Element>().ToArray());
        }

        [Route("api/elementNew")]
        [HttpGet]
        public ActionResult<List<string[]>> GetElementsNew()
        {
            //var csv = new List<string[]>(); // or, List<YourClass>
            //var lines = System.IO.File.ReadAllLines("..\\Shared\\Files\\Elements.csv");
            //foreach (string line in lines)
            //{
              //  csv.Add(line.Split(';')); // or, populate YourClass
                //JsonSerializer.SerializeToElement<Element>(line);
                //var serializer = new JavaScriptSerializer();
                //var serializedResult = serializer.Serialize(RegisteredUsers);
                //string json = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(csv);
            //}
            //return csv;
            var t = "a,b,c,d";
            var csv2 = new List<string[]>();
            csv2.Add(t.Split(','));
            return csv2;
        }
    }
}

