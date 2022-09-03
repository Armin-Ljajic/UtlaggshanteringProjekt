namespace Utläggningshantering.Models
{
    public class UserExpense
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string? PlaceOfPurchase { get; set; }
        public decimal AmountIncludingVAT { get; set; }
        public decimal VAT { get; set; }
        public string? Reason { get; set; }
        public string? Members { get; set; }
        public string? Comment { get; set; }
    }
}
