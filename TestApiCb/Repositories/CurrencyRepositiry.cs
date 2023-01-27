using TestApiCb.Interfaces;
using TestApiCb.Models;

namespace TestApiCb.Repositories
{
    public class CurrencyRepositiry : ICurrencyRepositiry
    {
        private readonly IDataConvert _dataConvert;

        public CurrencyRepositiry(IDataConvert dataConvert)
        {
            _dataConvert = dataConvert;
        }

        /// <summary>
        /// Возвращает курс валюты по коду
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Valutes> GetValuteAsync(string id)
        {
            var NewID = id.ToUpper().Trim();
            var data = await _dataConvert.GetValuteAllAsync();
            return data.GetValueOrDefault(NewID);
        }


        /// <summary>
        /// Вывод списка валюты
        /// </summary>
        /// <returns></returns>
        public async Task<List<Valutes>> GetValutesAllAsync()
        {
            var data = await _dataConvert.GetValuteAllAsync();
            return data.Values.ToList();
        }
    }
}
