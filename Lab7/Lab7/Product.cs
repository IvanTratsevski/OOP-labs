using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Lab7
{

    public abstract class Product
    {
        public string Name { get; set; }
        public string Priсe { get; set; }
        public int Discount { get; set; }
        public string TypeProduct { get; set; }

        public Product(string name, string priсe)
        {
            Name = name;
            Priсe = priсe;

        }
        public string ShowInfo()
        {
            return $" Товар - {Name}; Цена - {Priсe}; Скидка - {Discount}\n";
        }
        public abstract double GetPrise();

    }
    public class Discount1 : Product
    {
        public Discount1(string name, string price) : base(name, price)
        {
            Discount = 0;

        }
        public override double GetPrise()
        {
            return Convert.ToDouble(Priсe);
        }
    }
    public class Discount2 : Product
    {
        public Discount2(string name, string price) : base(name, price)
        {
            Discount = 10;

        }
        public override double GetPrise()
        {
            return Convert.ToDouble(Priсe) * 0.9;
        }
    }
    public class Discount3 : Product
    {
        public Discount3(string name, string price) : base(name, price)
        {
            Discount = 25;

        }
        public override double GetPrise()
        {
            return Convert.ToDouble(Priсe) * 0.75;
        }
    }
    public class DiscountNew : Product
    {
        public DiscountNew(string name, string price) : base(name, price)
        {
            Discount = 40;

        }
        public override double GetPrise()
        {
            return Convert.ToDouble(Priсe) * 0.6;
        }
    }


    public class MainClass
    {
        private List<Product> Product = new List<Product>();

        public string SumOfProduct()
        {
            double sum = 0;
            for (int i = 0; i < Product.Count; i++)
            {
                sum += Product[i].GetPrise();
            }
            return Convert.ToString(sum);
        }
        public void AddProduct(string name, string prise, string discount)
        {
            switch (discount)
            {
                case "0%":
                    Product.Add(new Discount1(name, prise));
                    break;
                case "10%":
                    Product.Add(new Discount2(name, prise));
                    break;
                case "25%":
                    Product.Add(new Discount3(name, prise));
                    break;
                case "40%":
                    Product.Add(new DiscountNew(name, prise));
                    break;
            }
        }
        public string GetAweragePriceByProduct()
        {
            string result = " ";
            List<string> names = new List<string>();
            for (int i = 0; i < Product.Count; i++)
            {
                if (!names.Contains(Product[i].Name))
                {
                    names.Add(Product[i].Name);
                }
            }
            for (int i = 0; i < names.Count; i++)
            {
                double priceByProduct = 0;
                int col = 0;
                for (int j = 0; j < Product.Count; j++)
                {
                    if (names[i] == Product[j].Name)
                    {
                        col++;
                        priceByProduct += Product[j].GetPrise();
                    }
                }
                result += $"{names[i]} - {priceByProduct / col}\n";
            }
            return result;
        }

        public string GetColProducts()
        {
            string result = " ";
            List<string> names = new List<string>();
            for (int i = 0; i < Product.Count; i++)
            {
                if (!names.Contains(Product[i].Name))
                {
                    names.Add(Product[i].Name);
                }
            }
            for (int i = 0; i < names.Count; i++)
            {
                int col = 0;
                for (int j = 0; j < Product.Count; j++)
                {
                    if (names[i] == Product[j].Name)
                    {
                        col++;
                    }
                }
                result += $"{names[i]} - {col}\n";
            }
            return result;
        }
        public string GetProductsWithDiscount()
        {
            int kol = 0;
            for (int i = 0; i < Product.Count; i++)
            {
                if (Product[i].Discount != 0)
                {
                    kol++;
                }
            }
            return $"Количество покупок со скидкой = {kol}";
        }

    }
}


