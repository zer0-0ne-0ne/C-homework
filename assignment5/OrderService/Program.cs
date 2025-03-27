using System;
using System.Collections.Generic;
using System.Linq;

// 订单明细类
public class OrderDetails
{
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }

    public OrderDetails(string productName, int quantity, double price)
    {
        ProductName = productName;
        Quantity = quantity;
        Price = price;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;
        OrderDetails other = (OrderDetails)obj;
        return ProductName == other.ProductName && Quantity == other.Quantity && Price == other.Price;
    }

    public override int GetHashCode()
    {
        return ProductName.GetHashCode() ^ Quantity.GetHashCode() ^ Price.GetHashCode();
    }

    public override string ToString()
    {
        return $"商品名称: {ProductName}, 数量: {Quantity}, 单价: {Price}";
    }
}

// 订单类
public class Order
{
    public string OrderId { get; set; }
    public string Customer { get; set; }
    public List<OrderDetails> OrderDetailsList { get; set; }

    public Order(string orderId, string customer)
    {
        OrderId = orderId;
        Customer = customer;
        OrderDetailsList = new List<OrderDetails>();
    }

    public double TotalAmount
    {
        get
        {
            return OrderDetailsList.Sum(d => d.Quantity * d.Price);
        }
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;
        Order other = (Order)obj;
        return OrderId == other.OrderId && Customer == other.Customer && OrderDetailsList.SequenceEqual(other.OrderDetailsList);
    }

    public override int GetHashCode()
    {
        return OrderId.GetHashCode() ^ Customer.GetHashCode();
    }

    public override string ToString()
    {
        string details = string.Join("\n", OrderDetailsList.Select(d => d.ToString()));
        return $"订单号: {OrderId}, 客户: {Customer}, 总金额: {TotalAmount}\n订单明细:\n{details}";
    }
}

// 订单服务类
public class OrderService
{
    private List<Order> orders = new List<Order>();

    // 添加订单
    public void AddOrder(Order order)
    {
        if (orders.Contains(order))
        {
            throw new ArgumentException("订单已存在，不能重复添加。");
        }
        orders.Add(order);
    }

    // 删除订单
    public void DeleteOrder(string orderId)
    {
        var orderToDelete = orders.FirstOrDefault(o => o.OrderId == orderId);
        if (orderToDelete == null)
        {
            throw new ArgumentException($"未找到订单号为 {orderId} 的订单，删除失败。");
        }
        orders.Remove(orderToDelete);
    }

    // 修改订单
    public void ModifyOrder(Order newOrder)
    {
        var oldOrder = orders.FirstOrDefault(o => o.OrderId == newOrder.OrderId);
        if (oldOrder == null)
        {
            throw new ArgumentException($"未找到订单号为 {newOrder.OrderId} 的订单，修改失败。");
        }
        oldOrder.Customer = newOrder.Customer;
        oldOrder.OrderDetailsList = newOrder.OrderDetailsList;
    }

    // 根据订单号查询订单
    public List<Order> QueryByOrderId(string orderId)
    {
        return orders.Where(o => o.OrderId == orderId).OrderBy(o => o.TotalAmount).ToList();
    }

    // 根据商品名称查询订单
    public List<Order> QueryByProductName(string productName)
    {
        return orders.Where(o => o.OrderDetailsList.Any(d => d.ProductName == productName)).OrderBy(o => o.TotalAmount).ToList();
    }

    // 根据客户查询订单
    public List<Order> QueryByCustomer(string customer)
    {
        return orders.Where(o => o.Customer == customer).OrderBy(o => o.TotalAmount).ToList();
    }

    // 根据订单金额查询订单
    public List<Order> QueryByTotalAmount(double amount)
    {
        return orders.Where(o => o.TotalAmount == amount).OrderBy(o => o.TotalAmount).ToList();
    }

    // 默认按订单号排序
    public void SortOrders()
    {
        orders = orders.OrderBy(o => o.OrderId).ToList();
    }

    // 自定义排序
    public void SortOrders(Func<Order, object> keySelector)
    {
        orders = orders.OrderBy(keySelector).ToList();
    }

    public List<Order> GetAllOrders()
    {
        return orders;
    }
}

class Program
{
    static void Main()
    {
        OrderService orderService = new OrderService();

        // 测试添加订单
        try
        {
            Order order1 = new Order("001", "张三");
            order1.OrderDetailsList.Add(new OrderDetails("苹果", 10, 5));
            orderService.AddOrder(order1);

            Order order2 = new Order("002", "李四");
            order2.OrderDetailsList.Add(new OrderDetails("香蕉", 20, 3));
            orderService.AddOrder(order2);

            Console.WriteLine("添加订单成功：");
            foreach (var order in orderService.GetAllOrders())
            {
                Console.WriteLine(order);
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

        // 测试删除订单
        try
        {
            orderService.DeleteOrder("001");
            Console.WriteLine("\n删除订单 001 成功：");
            foreach (var order in orderService.GetAllOrders())
            {
                Console.WriteLine(order);
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

        // 测试修改订单
        try
        {
            Order newOrder = new Order("002", "李四修改");
            newOrder.OrderDetailsList.Add(new OrderDetails("橙子", 15, 4));
            orderService.ModifyOrder(newOrder);
            Console.WriteLine("\n修改订单 002 成功：");
            foreach (var order in orderService.GetAllOrders())
            {
                Console.WriteLine(order);
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

        // 测试查询订单
        Console.WriteLine("\n按商品名称查询订单：");
        var result = orderService.QueryByProductName("橙子");
        foreach (var order in result)
        {
            Console.WriteLine(order);
        }

        // 测试排序
        orderService.SortOrders();
        Console.WriteLine("\n按订单号排序后：");
        foreach (var order in orderService.GetAllOrders())
        {
            Console.WriteLine(order);
        }
    }
}