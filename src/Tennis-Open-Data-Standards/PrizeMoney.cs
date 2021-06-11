using System.ComponentModel.DataAnnotations;

namespace Tennis_Open_Data_Standards
{
    public class PrizeMoney
    {
        [Key]
        public string PrizeMoneyId { get; set; }
        public string CurrencyCode { get; set; }

        //XML minOccurs=0 to 1
        public decimal? Amount{ get; set; }        
    }
}
