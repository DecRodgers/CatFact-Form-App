using CatFactAPI.Model.CatFact;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace CatFact_Form_App.Actions
{
    public class CatFactActions
    {
        //public Exception factNotFetchedException;
        public static async Task<CatFact> FetchFactAsync() {
            CatFact? sampleFact = null;
            HttpClient client = new();
            try
            {
                HttpResponseMessage response = await client.GetAsync("https://catfact.ninja/fact");
                response.EnsureSuccessStatusCode();
                sampleFact = JsonSerializer.Deserialize<CatFact>(await response.Content.ReadAsStreamAsync());
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\n Exception");
                Console.WriteLine("Message: {0}", e.Message);
            }
            return sampleFact;
        }
    }
}
