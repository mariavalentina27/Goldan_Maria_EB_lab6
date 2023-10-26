namespace Goldan_Maria_EB_lab6.Models
{
    public class Expense
    {
        public int ID { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Secret { get; set; }
    }
}
