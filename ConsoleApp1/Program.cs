class OrderCollection
{
   

    public class Order<TDelivery> where TDelivery : Delivery
    {
        public TDelivery Delivery;
        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.adress);
        }

        public void DisplayName()
        {
            Console.WriteLine(Delivery.name);
        }

        internal class Product
        {
            // id товара
            public int IdProduct;
            // описание товара
            public string DescriptionP;
            // сумма товара
            public double ResultPrice;
            // цена товара
            public int ProductPrice;
            // перегрузка методов получения суммы не более трёх)
            internal double Sum(double a)
            {
                return ResultPrice = a;
            }
            internal double Sum(double a, double b)
            {
                return ResultPrice = a + b;
            }
            internal double Sum(double a, double b, double c)
            { return ResultPrice = a + b + c; }
            public void DisplayPrice()
            {
                Console.WriteLine(ResultPrice);
            }
        }
    }
}
abstract public class Delivery
{
    // дата доставки:
    public int DataTime;
    // Имя получачтеля:
    public string name ;
    // адрес получателя:
    public string adress;
    public Delivery()
    { }
}
// класс доставки на дом
public class DeliveryHome : Delivery
{
    // курьерская компания
    internal string CompanyDriver;
    //имя курьера
    private string DriverName { get; set; }
}
// класс доставки в пункт выдачи
public class DeliveryCheckPoint : Delivery
{
    
    // срок хранения заказа в пункте выдачи
    DateTime date = new DateTime();
    // не уверен в следующем методе с хранением по времени 
    private void SaveOrderTime()
    {
        do
        {

        }
        while (date < date.AddDays(3));
    }
    // количество пунктов выдачи:
    public int CP = 10;
    // адресс пункта выдачи:  
    public string AdressCP { get; set; }
    
    //метод для массива адрессов пунктов выдачи 
    internal void PrintAdressCP(string[] AdressCP)
    {
        for (int i = 0; i < CP; i++)
        {
           AdressCP[i] = this.AdressCP;
        }
    }
}
// доставка до магазина
public class ShopDelivery : Delivery
{
   public string ShopAdress;
    public string ShopName;
}
