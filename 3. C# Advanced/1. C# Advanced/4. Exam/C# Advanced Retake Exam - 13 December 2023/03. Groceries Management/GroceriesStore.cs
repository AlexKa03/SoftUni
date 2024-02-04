using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GroceriesManagement
{
    public class GroceriesStore
    {
        private List<Product> Stall;
        public int Capacity { get; private set; }
        public double Turnover { get; private set; }

        public GroceriesStore(int capacity)
        {
            Capacity = capacity;
            Turnover = 0;
            Stall = new List<Product>();
        }

        public bool AddProduct(Product product)
        {
            if (Stall.Count < Capacity && !Stall.Any(p => p.Name == product.Name))
            {
                Stall.Add(product);
                return true;
            }
            return false;
        }

        public bool RemoveProduct(string name)
        {
            var product = Stall.FirstOrDefault(p => p.Name == name);
            if (product != null)
            {
                Stall.Remove(product);
                return true;
            }
            return false;
        }

        public string SellProduct(string name, double quantity)
        {
            var product = Stall.FirstOrDefault(p => p.Name == name);
            if (product == null)
            {
                return "Product not found";
            }
            double totalPrice = product.Price * quantity;
            Turnover += totalPrice;
            return $"{name} - {totalPrice:F2}$";
        }

        public string GetMostExpensive()
        {
            return Stall.OrderByDescending(p => p.Price).FirstOrDefault()?.ToString();
        }

        public string CashReport()
        {
            return $"Total Turnover: {Turnover:F2}$";
        }

        public string PriceList()
        {
            var builder = new StringBuilder();
            builder.AppendLine("Groceries Price List:");
            foreach (var product in Stall)
            {
                builder.AppendLine(product.ToString());
            }
            return builder.ToString().TrimEnd();
        }
    }
}