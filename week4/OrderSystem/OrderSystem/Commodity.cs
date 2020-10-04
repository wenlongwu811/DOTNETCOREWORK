using Shopping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping
{       /// <summary>
        /// 商品类
        /// </summary>
    public class Commodity
    {
        private string name;
        private double price;
        private int num;//数据库里面放的是总数，订单明细里面放的是购买的数量；

        public string Name { get => name; }
        public double Price { get => price; }
        public int Num { get { return num; } set => num = value; }
        public Commodity(string name, double price, int num)
        {
            this.name = name;
            this.price = price;
            this.num = num;
        }
    }
    class Is_Equal : Commodity
    {
        public override bool Equals(object obj)
        {
            Is_Equal m = obj as Is_Equal;
            return m.Name == Name;
        }

        public override int GetHashCode()
        {
            return 539060726 + EqualityComparer<string>.Default.GetHashCode(Name);
        }
        public Is_Equal(string name, double price, int num) : base(name, price, num) { }
    }

}
/*
  public override bool Equals(object obj)
        {
            Is_Equal m = obj as Is_Equal;
            return m.Name == Name;
        }

        public override int GetHashCode()
        {
            return ;
        }
        public Is_Equal(string name, double price, int num) : base(name, price, num) { }*/


