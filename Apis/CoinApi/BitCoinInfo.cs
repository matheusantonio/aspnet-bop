namespace CoinApi
{
    public class BitCoinInfo
    {
        public string updatedTime {get; set;}
        public float value {get; set;}

        public BitCoinInfo(string _time, float _value)
        {
            updatedTime = _time;
            value = _value;
        }
    }
}