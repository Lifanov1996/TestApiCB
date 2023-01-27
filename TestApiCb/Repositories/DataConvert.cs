using TestApiCb.Interfaces;
using TestApiCb.Models;

namespace TestApiCb.Repositories
{
    public class DataConvert : IDataConvert
    {
        private ICurrencyService _currencySer { get; }

        public DataConvert(ICurrencyService currencyService)
        {
            _currencySer = currencyService;
        }

        /// <summary>
        /// Запись Valute в список 
        /// </summary>
        /// <returns></returns>
        public async Task<Dictionary<string, Valutes>> GetValuteAllAsync()
        {
            var response = await _currencySer.GetCurrencyAsync();

            var valute = new Dictionary<string, Valutes>();
            foreach (var item in response.Valute)
            {
                valute.Add(item.Key, item.Value);
            }

            return valute;
        }
    }
}
