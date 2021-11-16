namespace financial_chat.Models
{
    public class Stock
    {
        public string Symbol { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Open { get; set; }
        public string High { get; set; }
        public string Low { get; set; }
        public string Close { get; set; }
        public string Volume { get; set; }

        public Stock(string csv, string del)
        {
            Symbol = csv.Split(del)[0];
            Date = csv.Split(del)[1];
            Time = csv.Split(del)[2];
            Open = csv.Split(del)[3];
            High = csv.Split(del)[4];
            Low = csv.Split(del)[5];
            Close = csv.Split(del)[6];
            Volume = csv.Split(del)[7];
        }
    }
}
