using Microsoft.AspNetCore.Mvc;
using TestApiCb.Interfaces;
using TestApiCb.Models;

namespace TestApiCb.Controllers
{
    [Route("currency")]
    [ApiController]
    public class ValuteController : ControllerBase
    {
        private readonly ICurrencyRepositiry _currencyRepositiry;
        public ValuteController(ICurrencyRepositiry currencyRepositiry)
        {
            _currencyRepositiry = currencyRepositiry;
        }
            

        /// <summary>
        /// Возвращает курс одной валюты 
        /// </summary>
        /// <param name="CharCod">Код валюты</param>
        /// <returns></returns>
        [HttpGet("{CharCod}")]
        public async Task<ActionResult<Valutes>> GetValuteBuIdAsync(string CharCod)
        {
            try
            {
                var result = await _currencyRepositiry.GetValuteAsync(CharCod);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
    
}
