string[] orderStream = ["B123","C234","A345","C15","B177","G3003","C235","B179"];
Array.Sort(orderStream);
foreach (var orders in orderStream)
{
    if(orders.Length == 4)
    {
        Console.WriteLine($"{orders}");
    }   
    else
    {
        Console.WriteLine($"{orders} - error");
    }
}
