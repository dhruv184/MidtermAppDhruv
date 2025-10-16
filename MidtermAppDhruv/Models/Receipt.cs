namespace MidtermAppDhruv.Models;

public class Receipt
{
    public string CustomerName { get; set; }
    public string PhoneType { get; set; }
    public string PhoneColor { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public decimal SubTotal { get; set; }
    public decimal Discount { get; set; }
    public decimal Tax { get; set; }
    public decimal Total { get; set; }
}