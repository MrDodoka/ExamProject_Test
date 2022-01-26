using CoinGecko.Clients;
using CoinGecko.Entities.Response.Coins;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExamProject_Test.Controllers
{
    public class CoinGeckoController
    {
        CoinGeckoClient CG = new();

        public async Task<List<CoinMarkets>>TestCGMethod()
        {

            var asd = await CG.CoinsClient.GetCoinMarkets("usd", new string[] { }, null, null, null, false, null, null);

            return asd;
        }
    }
}
