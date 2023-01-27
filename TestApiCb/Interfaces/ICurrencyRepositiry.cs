using TestApiCb.Models;

namespace TestApiCb.Interfaces
{
    public interface ICurrencyRepositiry
    {
        Task<Valutes> GetValuteAsync(string CharCod);
        Task<List<Valutes>> GetValutesAllAsync();
    }
}
