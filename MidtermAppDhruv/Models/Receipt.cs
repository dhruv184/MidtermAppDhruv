namespace MidtermAppDhruv.Models;

public class Receipt
{
    public string CustomerName { get; set; }
    public string PhoneType { get; set; }
    public string PhoneColor { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public decimal SubTotal { get; set; }
    public decimal Tip { get; set; }
    public string PaymentMethod { get; set; }
    public decimal Total { get; set; }
}