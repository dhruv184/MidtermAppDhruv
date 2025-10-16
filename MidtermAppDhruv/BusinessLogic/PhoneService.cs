using MidtermAppDhruv.Models;

namespace MidtermAppDhruv.BusinessLogic;

public class PhoneService
{
    public Receipt CalcuateReceipt(PhoneOrder order)
    {
        var receipt = new Receipt
        {
            CustomerName = order.CustomerName,
            PhoneType = order.PhoneType,
            PhoneColor = order.PhoneColor,
            Quantity = order.Quantity,
        };

        decimal price = 0;

        if (order.PhoneType == "Android")
        {
            if (order.PhoneColor == "Black")
                price = 800;
            else if (order.PhoneColor == "White")
                price = 800;
            else if (order.PhoneColor == "Red")
                price = 800;
        }
        else if  (order.PhoneType == "Apple")
        {
            if (order.PhoneColor == "Black")
                price = 1200;
            else if (order.PhoneColor == "White")
                price = 1200;
            else if (order.PhoneColor == "Red")
                price = 1200;
        }
        else if  (order.PhoneType == "Samsung Galaxy")
        {
            if (order.PhoneColor == "Black")
                price = 400;
            else if (order.PhoneColor == "White")
                price = 400;
            else if (order.PhoneColor == "Red")
                price = 400;
        }
        
        receipt.Price = price;
        receipt.SubTotal = price  * order.Quantity;

        if (true)
            receipt.Tip = receipt.SubTotal + (decimal)0.5;
        else
            receipt.Tip = 0;
        
        receipt.Total = receipt.SubTotal + receipt.Tip;
        return receipt;
    }
}