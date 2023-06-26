using System;

class Program
{
    static void Main(string[] args)
    {
        // Создаем экземпляр класса Goods
        var goods = new Goods("Шоколадка", DateTime.Now, 50, 10, "INV001", new DateTime(2023, 6, 1));

        // Выводим информацию о товаре
        Console.WriteLine($"Товар: {goods.Name}");
        Console.WriteLine($"Дата оформления: {goods.Date}");
        Console.WriteLine($"Цена: {goods.Price}");
        Console.WriteLine($"Количество: {goods.Quantity}");
        Console.WriteLine($"Номер накладной: {goods.InvoiceNumber}");
        Console.WriteLine($"Дата поступления на склад: {goods.ArrivalDate}");
        Console.WriteLine($"Стоимость: {goods.GetCost()}");
        Console.WriteLine($"Срок хранения: {goods.GetStorageTimeInDays()} дней");

        // Изменяем цену товара и выводим новую стоимость
        goods.ChangePrice(60);
        Console.WriteLine($"Новая цена: {goods.Price}");
        Console.WriteLine($"Новая стоимость: {goods.GetCost()}");

        // Увеличиваем количество товара и выводим новое количество и стоимость
        goods.IncreaseQuantity(5);
        Console.WriteLine($"Новое количество: {goods.Quantity}");
        Console.WriteLine($"Новая стоимость: {goods.GetCost()}");

        // Уменьшаем количество товара и выводим новое количество и стоимость
        goods.DecreaseQuantity(3);
        Console.WriteLine($"Новое количество: {goods.Quantity}");
        Console.WriteLine($"Новая стоимость: {goods.GetCost()}");
    }
}