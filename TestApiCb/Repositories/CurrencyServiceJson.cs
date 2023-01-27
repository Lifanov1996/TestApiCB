using System.Net.Http.Headers;
using TestApiCb.Interfaces;
using TestApiCb.Models;

namespace TestApiCb.Repositories
{
    public class CurrencyServiceJson : ICurrencyService
    {
        private const string RequestUrl = "https://www.cbr-xml-daily.ru/daily_json.js";
        private HttpClient client;

        public CurrencyServiceJson()
        {
            client = new();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<Root> GetCurrencyAsync()
        {
            var response = await client.GetAsync(RequestUrl);

            if (response.IsSuccessStatusCode)
            {
                return await client.GetFromJsonAsync<Root>(RequestUrl);
            }

            throw new ArgumentNullException(response.ToString());
        }
    }
}
