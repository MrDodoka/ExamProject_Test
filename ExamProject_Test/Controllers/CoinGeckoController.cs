using CoinGecko.Clients;
using CoinGecko.Entities.Response.Coins;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExamProject_Test.Controllers
{
    public class CoinGeckoController
    {
        static CoinGeckoClient CG = new();

        public async Task<List<CoinMarkets>>GetTopTenCoins()
        {

            var coin = await CG.CoinsClient.GetCoinMarkets("usd", new string[] { }, null, null, null, false, null, null);

            return coin;
        }

        public async Task<CoinFullDataById> GetTopNCoin(string id)
        {
            var coin = await CG.CoinsClient.GetAllCoinDataWithId(id);
            return coin;
        }
    }
}
