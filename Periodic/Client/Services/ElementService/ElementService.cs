using System.Net.Http.Json;

namespace Periodic.Client.Services.ElementService
{
    public class ElementService : IElementService
    {
        private readonly HttpClient _http;

        public ElementService(HttpClient http)
        {
            _http = http;
        }
        public List<Element> Elements { get; set; } = new List<Element>();

        public async Task GetElements()
        {
            try
            {

                var result = await _http.GetFromJsonAsync<List<Element>>("api/elementNew");
                if (result != null)
                {
                    Elements = result;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public List<string[]> Elstring { get; set; } = new List<string[]>();
        public async Task GetElementsNew()
        {
            try
            {

                var result = await _http.GetFromJsonAsync<List<string[]>>("api/element");
                if (result != null)
                {
                    Elstring = result;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
