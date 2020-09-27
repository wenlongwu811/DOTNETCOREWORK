using System;
using System.Collections.Generic;

namespace Shopping
{
    class Program
    {
        static int orderID = 0;
        static int sumOrderID = 0;
        static void Main(string[] args)
        {
            Dictionary<int, Commodity> dic_com = new Dictionary<int, Commodity>();
            Commodity commodity1= new Commodity("Apple", 5, 40);
            Commodity commodity2= new Commodity("Banana", 3, 30);
            Commodity commodity3 = new Commodity("mango", 10, 20);
            Commodity commodity4 = new Commodity("grape", 8, 8);
            OrderDetails orderDetails1 = new OrderDetails(orderID++);//用户1
            OrderDetails orderDetails2 = new OrderDetails(orderID++);//用户2
            Order order1 = new Order(sumOrderID++);//总表1
            Dictionary<int, Order> dic_order = new Dictionary<int, Order>();
            dic_order[order1.SumorderID] = order1;
            Dictionary<int, OrderDetails> dic_orderDetails = new Dictionary<int, OrderDetails>();
            dic_orderDetails[orderDetails1.OrderID] = orderDetails1;
            dic_orderDetails[orderDetails2.OrderID] = orderDetails2;
            OrderService orderService = new OrderService(dic_order,dic_orderDetails);
            orderService.Add_Commodity(commodity1,orderService.Dic_orderDetails[0].OrderID);
            orderService.Add_Commodity(commodity2, orderService.Dic_orderDetails[0].OrderID);
            orderService.Add_Commodity(commodity1, orderService.Dic_orderDetails[1].OrderID);
        }
    }
}
