using TestApiCb.Models;

namespace TestApiCb.Interfaces
{
    public interface ICurrencyService
    {
        Task<Root> GetCurrencyAsync();
    }
}
