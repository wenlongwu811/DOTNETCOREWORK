using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Shopping
{/// <summary>
/// 订单服务：针对单个Commodity，操作OrderDetails，放入或查询Order
/// </summary>
    class OrderService
    {
        Dictionary<int, OrderDetails> dic_orderDetails;
        Dictionary<int, Order> dic_order;//int 是Order的ID

        internal Dictionary<int, OrderDetails> Dic_orderDetails { get => dic_orderDetails; set => dic_orderDetails = value; }

        public OrderService(Dictionary<int, Order> dic, Dictionary<int, OrderDetails> dic2)
        {
            dic_order = dic;
            Dic_orderDetails = dic2;
        }

        public int Is_OrderDetails(Commodity i, int id)//返回index
        {
            int index = -1;
            foreach (var item in Dic_orderDetails[id].Commodities)
            {
                if (i.Equals(item))
                {
                    index = Dic_orderDetails[id].Commodities.IndexOf(item);//记录相同对象的索引
                    break;
                }
            }
            return index;
        }
        public void Add_Commodity(Commodity i, int id)//库里面的商品会减少1个,m表示给第几个用户,即用户id
        {

            if (i.Num != 0)
            {
                int index = Is_OrderDetails(i, id);
                if (index != -1)
                {
                    Dic_orderDetails[id].Commodities[index].Num++;//在相同对象的num++

                }
                else
                {
                    Commodity m = new Commodity(i.Name, i.Price, 1);
                    Dic_orderDetails[id].Commodities.Add(m);
                }
            }
            else
                throw new Exception("商品" + i.Name + "已售空。");
        }
        public void Del_Commodity(Commodity i, int id)//库里面的商品会增加1个
        {
            int index = Is_OrderDetails(i, id);
            if (index != -1)
            {
                Dic_orderDetails[id].Commodities[index].Num--;//在相同对象的num--
            }
            else
                throw new Exception("订单里面没有该商品。");
        }
        //查询方法写在order里面了
        public OrderDetails SearchID(int id)//查询ID
        {
            int count0 = 0;
            foreach (var item in dic_order.Keys)
            {
                var orderID = from n in dic_order[item].OrderDetails
                              where n.OrderID == id
                              select n;
                count0++;
                if (count0 == dic_order.Count)
                {
                    List<OrderDetails> list = orderID.ToList();
                    if (list.Count != 0) { return list.First(); }
                }
            }
            throw new ArgumentOutOfRangeException("不存在的ID");
        }
    }
}
