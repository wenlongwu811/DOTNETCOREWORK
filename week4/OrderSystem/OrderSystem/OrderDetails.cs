using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping
{/// <summary>
/// 订单明细：存放用户的订单表
/// </summary>
    public class OrderDetails
    {/// <summary>
     /// 每创建一个用户，都会生成一个ID,和一个shopping清单
     /// </summary>
        public int orderID;
        public OrderDetails(int orderID)
        {
            this.orderID = orderID;
        }
        public List<Commodity> commodities = new List<Commodity>();
        public int OrderID { get => orderID; }
        public List<Commodity> Commodities { get => commodities; set => commodities = value; }
        public override string ToString()
        {
            if (commodities.Count == 0)
            {
                throw new ArgumentOutOfRangeException("没有商品。");
            }
            foreach (var item in commodities)
            {
                Console.WriteLine(item.Name + "；" + item.Num + "个， 总价" + item.Price * item.Num);
            }
            return "订单如上";
        }

    }
}
