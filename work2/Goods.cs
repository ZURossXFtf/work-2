using System;
using work2;

public class Goods
{
    public string Name { get; set; }
    public DateTime Date { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
    public string InvoiceNumber { get; set; }
    public DateTime ArrivalDate { get; set; }

    public Goods(string name, DateTime date, double price, int quantity, string invoiceNumber, DateTime arrivalDate)
    {
        Name = name;
        Date = date;
        Price = price;
        Quantity = quantity;
        InvoiceNumber = invoiceNumber;
        ArrivalDate = arrivalDate;
    }

    public void ChangePrice(double newPrice)
    {
        Price = newPrice;
    }

    public void IncreaseQuantity(int amount)
    {
        Quantity += amount;
    }

    public void DecreaseQuantity(int amount)
    {
        Quantity -= amount;
    }

    public double GetCost()
    {
        return Price * Quantity;
    }

    public int GetStorageTimeInDays()
    {
        var currentDate = DateTime.Now;
        return (int)(currentDate - ArrivalDate).TotalDays;
    }

    public override string ToString()
    {
        return $"Стоимость товара '{Name}': {GetCost()}, срок хранения: {GetStorageTimeInDays()} дней";
    }
}