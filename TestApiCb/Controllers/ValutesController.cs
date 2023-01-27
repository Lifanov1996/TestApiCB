using Microsoft.AspNetCore.Mvc;
using TestApiCb.Interfaces;
using TestApiCb.Models;

namespace TestApiCb.Controllers
{
    [Route("currencies")]
    [ApiController]
    public class ValutesController : ControllerBase
    {
        private readonly ICurrencyRepositiry _currencyRepositiry;
        public ValutesController(ICurrencyRepositiry currencyRepositiry)
        {
            _currencyRepositiry = currencyRepositiry;
        }


        [HttpGet]
        public async Task<ActionResult<List<Valutes>>> GetValuteAllAsync(int? pageNum = null, int? pageSize = null)
        {
            try
            {
                var result = await _currencyRepositiry.GetValutesAllAsync();
                if (pageNum == null && pageSize == null)
                {
                    return Ok(result);
                }

                return Ok(result.GroupBy(x => x.Name)
                                .Skip((pageNum ?? 0) * pageSize ?? 5)
                                .Take(pageSize ?? 5));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }

}
