namespace Shared.Contracts
{
    public class PaymentRejectedEvent
    {
        public int OrderId { get; set; }
        public string Reason { get; set; }
    }
}