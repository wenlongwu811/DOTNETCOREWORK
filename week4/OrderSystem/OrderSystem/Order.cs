using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Shopping
{/// <summary>
/// 订单类：存放订单明细列表
/// </summary>
    public class Order
    {/// <summary>
     /// 订单表ID，用来区分不同的订单总表，订单明细ID只是用来区分不同的用户
     /// </summary>
        private int sumorderID;
        public Order(int sumorderID)
        {
            this.SumorderID = sumorderID;
        }
        private List<OrderDetails> orderDetails = new List<OrderDetails>();

        internal List<OrderDetails> OrderDetails { get => orderDetails; set => orderDetails = value; }
        public int SumorderID { get => sumorderID; set => sumorderID = value; }
        public override string ToString()
        {
            if (orderDetails.Count == 0)
            {
                throw new ArgumentOutOfRangeException("订单里面为空。");
            }
            else foreach (var item in orderDetails)
            {
                Console.WriteLine(item.ToString());
            }
            return "订单细节如上";
        }


    }
    class Is_Order : Order
    {
        /*public override bool Equals(object obj)
        {
            Is_Order m = obj as Is_Order;
            return m.SumorderID == SumorderID;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(OrderDetails);
        }*/

        public Is_Order(int sumdoder) : base(sumdoder)
        { }

        public override bool Equals(object obj)
        {
            return obj is Is_Order order &&
                   SumorderID == order.SumorderID;
        }

        public override int GetHashCode()
        {
            return -189035739 + SumorderID.GetHashCode();
        }
    }
}
