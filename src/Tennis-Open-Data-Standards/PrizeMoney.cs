namespace Tennis_Open_Data_Standards
{
    public class PrizeMoney
    {
        public string CurrencyCode { get; set; }

        //XML minOccurs=0 to 1
        public decimal? Amount{ get; set; }        
    }
}
