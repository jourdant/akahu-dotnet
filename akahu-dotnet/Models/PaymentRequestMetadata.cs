namespace Akahu.Api.Models
{
    public class PaymentRequestMetadata
    {
        public PaymentRequestDetail Source { get; set; }
        public PaymentRequestDetail Destination { get; set; }
    }
}