using System;
using System.Net;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json.Linq;

namespace CoinApi
{
    public class CoinApi : IApiLoader
    {
        public static BitCoinInfo bitCoinInfo = GetBitcoinValue(RequestBitcoinStatus());

        public string apiGet()
        {
            return bitCoinInfo.updatedTime + ": R$" + bitCoinInfo.value;
        }

        private static string RequestBitcoinStatus()
        {
            var webRequest = WebRequest.Create("http://api.coindesk.com/v1/bpi/currentprice/BRL.json") as HttpWebRequest;

            WebResponse response = webRequest.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            return reader.ReadToEnd();
        }

        private static BitCoinInfo GetBitcoinValue(string jsonStream)
        {
            JObject jObject = JObject.Parse(jsonStream);

            string time = (string)jObject["time"]["updated"];
            float brl = (float)jObject["bpi"]["BRL"]["rate_float"];

            BitCoinInfo bitCoin = new BitCoinInfo(time, brl);

            return bitCoin;
        } 
    }
}
