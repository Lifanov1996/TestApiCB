using TestApiCb.Models;

namespace TestApiCb.Interfaces
{
    public interface IDataConvert
    {
        Task<Dictionary<string, Valutes>> GetValuteAllAsync();
    }
}

