using PayStackTesting.Models.Entities.Data;

public class PaymentRequest : BaseEntity
{
    public Guid Id { get; set; }
    public string Email { get; set; }
    public decimal Amount { get; set; }
    public string TransactionReference { get; set; }
    public string Status { get; set; }
    public DateTime DateRequested { get; set; } = DateTime.Now;
}